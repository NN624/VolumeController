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

        // ���ʂ��グ�����Ȃ��悤�ɂ��邽�߂̃^�C�}�[
        private static System.Timers.Timer aTimer;
        public static bool enable_timer = false;

        // �f�o�C�X���������邽�߂̐ݒ�
        MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
        public MMDevice device;

        // �T���v���Đ��p�̏���
        WaveOutEvent waveOut = new WaveOutEvent();
        AudioFileReader afr = new AudioFileReader("../../../400hz-9db-20sec.wav");

        public Form1()
        {
            InitializeComponent();

            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // ���݂̉��ʂ��擾���āA�����l�Ƃ��Đݒ�
            volume_label.Text = System.Convert.ToString(GetVolume());
            volume_trackBar.Value = GetVolume();
            // �f�o�C�X�̈ꗗ���擾
            devices_cmb.Items.AddRange(GetDevices());
        }

        // 1�~���b�Ԋu�ŌJ��Ԃ�������
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (devices_cmb.SelectedItem != null)
            {

                // peak_pb�̒l���X�V
                var device = (MMDevice)devices_cmb.SelectedItem;
                peak_pb.Value = (int)(Math.Round((device.AudioMeterInformation.MasterPeakValue * 100)));
                progres_value.Text = System.Convert.ToString(peak_pb.Value);

                // PC�̉��ʂ��擾
                //var volume = GetVolume();

                // ���ʂ�ύX
                if (peak_pb.Value != 0)
                {
                    // switch�݂����ȉ��ʒ���
                    if (peak_pb.Value > 80)
                    {
                        SetVolume(3);
                    }
                    else if (peak_pb.Value > 30)
                    {
                        SetVolume(6);
                    }
                    else
                    {
                        SetVolume(9);
                    }

                    /*
                    // ��ŉ��ʒ���
                    // �ݒ肳��Ă���
                    //double a = (GetVolume() * peak_pb.Value)/10000.0d;
                    double now_standard = (GetVolume() + peak_pb.Value) / 200.0d;

                    // �ݒ肳��Ă����̒l�ƌ��݂̊�𓙂������邽�߂̉��ʂ��v�Z
                    double c = System.Convert.ToDouble(standard_label.Text)/100.0d * 200.0d - peak_pb.Value;
                    real_trackBar.Value = (int)(((c + (double)peak_pb.Value) / 200.0d)*100);

                    Debug.WriteLine("a:" + (double)standard_trackBar.Value / 100.0d + ",b:" + now_standard);
                    if (Math.Abs(standard_trackBar.Value/100 - now_standard) < 0.1)
                    {
                        //Debug.WriteLine(Math.Abs(standard_trackBar.Value / 100 - now_standard));
                    }
                    else if (c > 0)
                    {
                        SetVolume((int)c);
                    }

                    // 0, 0.355, 0
                    // a:0.71,b:0.855,c:100
                    //Debug.WriteLine("a:" + standard_label.Text + ",b:" + real_trackBar.Value + ",c:" + c);
                    //Debug.WriteLine("c:" + c);
                    
                    //SetVolume(GetVolume() * peak_pb.Value);
                    */
                }
                else
                {

                }

                // �ő�̉��ʂ𐧌�
                /*
                if ((sum_trackBar.Value > standard_trackBar.Value) && peak_pb.Value != 0)
                {
                    // volume�̑傫���ɂ���ĉ����鉹�ʂ̕���ύX����
                    //SetVolume(volume - (int)Math.Ceiling((double)volume / 10.0d));
                    SetVolume(volume - 1);
                    volume_trackBar.Value = volume;
                }

                // �ŏ��̉��ʂ𐧌�
                if ((sum_trackBar.Value) < (min_trackBar.Value) && peak_pb.Value != 0 && enable_timer == false)
                {
                    // volume�̑傫���ɂ���ĉ����鉹�ʂ̕���ύX����
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
                */
                

                // �T���v�������̃��[�v
                afr.Position = 0;
            }
        }

        private void standard_set_btn_Click(object sender, EventArgs e)
        {
            standard_label.Text = System.Convert.ToString((GetVolume() + peak_pb.Value) / 200.0d * 100);
            standard_trackBar.Value = (int)((GetVolume() + peak_pb.Value) / 200.0d * 100);
        }

        private void volume_trackBar_Scroll(object sender, EventArgs e)
        {
            SetVolume(volume_trackBar.Value);
        }

        
        private void standard_trackBar_Scroll(object sender, EventArgs e)
        {
            standard_label.Text = System.Convert.ToString(standard_trackBar.Value);
        }

        private void media_btn_Click(object sender, EventArgs e)
        {
            if (waveOut.PlaybackState == PlaybackState.Stopped)
            {
                waveOut.Init(afr);
                waveOut.Play();
                media_btn.Text = "�T���v����~";
            }
            else if (waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Stop();
                media_btn.Text = "�T���v���Đ�";
            }
        }
        private void active_btn_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                active_btn.Text = "�N��";
            }
            else
            {
                timer1.Start();
                active_btn.Text = "��~";
            }
        }

        /*
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
            //min_trackBar.Value = (int)(GetVolume() * peak_pb.Value / 100);
            //min_volume.Text = System.Convert.ToString(min_trackBar.Value);
        }

        // ���ʂ̒Z���ԘA���㏸��h��
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            // �P�b
            aTimer = new System.Timers.Timer(5000);
            Debug.WriteLine("start");
            // Hook up the Elapsed event for the timer.
            enable_timer = true;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

        }
        */
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


        // ���\�b�h:���ʂ̕ύX
        public int SetVolume(int volume)
        {
            // ���ʂ�ύX�i�͈́F0.0�`1.0�j
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

        // ���\�b�h�F���ʂ̎擾 return�F0.00�`1.00 
        public int GetVolume()
        {
            return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        }

        // ���\�b�h�F�f�o�C�X�̈ꗗ���擾
        public object[] GetDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            return devices.ToArray();
        }

        
    }

    /*
    // ���ʒ���������
    class VolumeController
    {
        public MMDevice device;

        // VolumeController�̃R���X�g���N�^�[
        public VolumeController()
        {
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        // ���\�b�h:���ʂ̕ύX
        public int SetVolume(int volume)
        {
            // ���ʂ�ύX�i�͈́F0.0�`1.0�j
            volume = volume < 0 ? 0 : volume;
            device.AudioEndpointVolume.MasterVolumeLevelScalar = ((float)volume / 100.0f);

            return GetVolume();
        }

        // ���\�b�h�F���ʂ̎擾
        public int GetVolume()
        {
            return (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
        }

        // ���\�b�h�F�f�o�C�X�̈ꗗ���擾
        public object[] GetDevices()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            return devices.ToArray();
        }
    }
    */
}