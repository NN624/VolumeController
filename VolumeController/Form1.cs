using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;

namespace VolumeController
{
    public partial class Form1 : Form
    {

        //private VolumeController vc = new VolumeController();
        private static System.Timers.Timer aTimer;
        public static bool enable_timer = false;

        MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
        public MMDevice device;


        // サンプル再生用の準備
        WaveOutEvent waveOut = new WaveOutEvent();
        AudioFileReader afr = new AudioFileReader("C:\\Users\\s192034.TSITCL\\OneDrive - Cyber University\\School\\卒業研究\\GraduationResearch\\VolumeController\\VolumeController\\400hz-9db-20sec.wav");
        //AudioFileReader afr = new AudioFileReader("C:\\Users\\s192034.TSITCL\\OneDrive - Cyber University\\School\\卒業研究\\GraduationResearch\\VolumeController\\VolumeController\\5khz-6db-20sec.wav");

        public Form1()
        {
            InitializeComponent();

            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // 現在の音量を取得して、初期値として設定
            volume_label.Text = System.Convert.ToString(GetVolume());
            volume_trackBar.Value = GetVolume();
            // デバイスの一覧を取得
            devices_cmb.Items.AddRange(GetDevices());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (devices_cmb.SelectedItem != null)
            {
                
                var device = (MMDevice)devices_cmb.SelectedItem;
                // progressBar1の値を変更
                peak_pb.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
                progres_value.Text = System.Convert.ToString(peak_pb.Value);

                // 音量を取得
                var volume = GetVolume();
                // Debug.WriteLine(progressBar1.Value * volume);
                //Debug.WriteLine(progressBar1.Value + volume);
                //sum_trackBar.Value = (int)((GetVolume()/100.0d) * (progressBar1.Value / 100.0d));
                
                sum_trackBar.Value = (int)(GetVolume() * peak_pb.Value / 100);
                //sum_trackBar.Value = (int)(GetVolume() + progressBar1.Value / 200 / 2);

                //max_trackBar.Value = (int)((GetVolume() / 100.0d) * (progressBar1.Value / 100.0d) * 100);
                //Debug.WriteLine(sum_trackBar.Value);

                // 最大の音量を制限
                if ((sum_trackBar.Value > standard_trackBar.Value) && peak_pb.Value != 0)
                {
                    // volumeの大きさによって下げる音量の幅を変更する
                    //SetVolume(volume - (int)Math.Ceiling((double)volume / 10.0d));
                    SetVolume(volume - 1);
                    volume_trackBar.Value = volume;
                }

                // 最小の音量を制限
                if ((sum_trackBar.Value) < (min_trackBar.Value) && peak_pb.Value != 0 && enable_timer == false)
                {
                    // volumeの大きさによって下げる音量の幅を変更する
                    //SetVolume(volume + (int)Math.Ceiling((double)volume / 10.0d));
                    SetVolume(volume + 1);
                    volume_trackBar.Value = volume;
                    //
                    SetTimer();
                }
                if ((peak_pb.Value == 0) && volume_trackBar.Value != 0)
                {
                    SetVolume(0);

                }

                if (peak_pb.Value != 0 && volume_trackBar.Value == 0 && standard_trackBar.Value != 100)
                {
                    SetVolume(standard_trackBar.Value);
                }
                

                // サンプル音源のループ
                afr.Position = 0;
            }
        }

        private void volume_trackBar_Scroll(object sender, EventArgs e)
        {
            SetVolume(volume_trackBar.Value);
        }

        private void max_trackBar_Scroll(object sender, EventArgs e)
        {
            standard_label.Text = System.Convert.ToString(standard_trackBar.Value);
        }

        private void min_trackBar_Scroll(object sender, EventArgs e)
        {
            min_volume.Text = System.Convert.ToString(min_trackBar.Value);
        }

        private void media_btn_Click(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState == PlaybackState.Stopped)
            {
                waveOut.Init(afr);
                waveOut.Play();
                media_btn.Text = "stop";
            }
            else if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                media_btn.Text = "play";
            }
        }

        private void max_btn_Click(object sender, EventArgs e)
        {
            //max_trackBar.Value = (int)Math.Floor((double)(GetVolume() * (progressBar1.Value / 100)) * 100.0d);
            standard_trackBar.Value = (int)(GetVolume() * peak_pb.Value / 100);
            standard_label.Text = System.Convert.ToString(standard_trackBar.Value);
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            //min_trackBar.Value = (int)Math.Floor((double)(GetVolume() * progressBar1.Value) / 100.0d);
            //min_trackBar.Value = (int)(GetVolume() * (progressBar1.Value / 100.0d)) * 100;
            //min_trackBar.Value = (int)((GetVolume() / 100.0d) * (progressBar1.Value / 100.0d) * 100);
            min_trackBar.Value = (int)(GetVolume() * peak_pb.Value / 100);
            min_volume.Text = System.Convert.ToString(min_trackBar.Value);
        }

        // 音量の短時間連続上昇を防ぐ
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            // １秒
            aTimer = new System.Timers.Timer(5000);
            Debug.WriteLine("start");
            // Hook up the Elapsed event for the timer.
            enable_timer = true;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            enable_timer = false;
            Debug.WriteLine("stop");
        }

        /*
        public void update()
        {

        }
        */


        // メソッド:音量の変更
        public int SetVolume(int volume)
        {
            // 音量を変更（範囲：0.0～1.0）
            if (volume < 0)
            {
                volume = 0;
            }else if (volume > 100)
            {
                volume = 100;
            }
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)volume / 100.0f);
            volume_trackBar.Value = volume;
            volume_label.Text = System.Convert.ToString(volume);


            return GetVolume();
        }

        // メソッド：音量の取得 return：0.00～1.00 
        public int GetVolume()
        {
            return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        }

        // メソッド：デバイスの一覧を取得
        public object[] GetDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            return devices.ToArray();
        }

    }

    /*
    // 音量調整をする
    class VolumeController
    {
        public MMDevice device;

        // VolumeControllerのコンストラクター
        public VolumeController()
        {
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        // メソッド:音量の変更
        public int SetVolume(int volume)
        {
            // 音量を変更（範囲：0.0～1.0）
            volume = volume < 0 ? 0 : volume;
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)volume / 100.0f);

            return GetVolume();
        }

        // メソッド：音量の取得
        public int GetVolume()
        {
            return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        }

        // メソッド：デバイスの一覧を取得
        public object[] GetDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            return devices.ToArray();
        }
    }
    */
}