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
        //AudioFileReader afr = new AudioFileReader("../../../400hz-9db-20sec.wav");
        AudioFileReader afr = new AudioFileReader("C:\\Users\\s192034.TSITCL\\OneDrive - Cyber University\\School\\���ƌ���\\VolumeController\\VolumeController\\400hz-3db-20sec.wav");

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
                var volume = GetVolume();

                /*
                // ��Ɍ덷�͈͂���������
                real_trackBar.Value = (GetVolume() + peak_pb.Value) / 2;
                real_trackbar_label.Text = System.Convert.ToString(real_trackBar.Value);
                // �덷�͈�
                int diff = 5;
                int min = standard_trackBar.Value - diff;
                int max = standard_trackBar.Value + diff;

                if (peak_pb.Value != 0)
                {
                    // �ő�̉��ʂ𐧌�
                    if (real_trackBar.Value > max)
                    {
                        SetVolume(volume - 1);
                    }
                    // �ŏ��̉��ʂ𐧌�
                    if (real_trackBar.Value < min)
                    {
                        SetVolume(volume + 1);
                    }
                    
                }
                */


                // ���ʂ�ύX
                if (peak_pb.Value != 0)
                {
                    // �s�[�N�Ɖ��ʂ̊
                    //double a = (GetVolume() * peak_pb.Value)/10000.0d;
                    double b = (GetVolume() + peak_pb.Value) / 200.0d;
                    // real_trackbar��standared_trackbar�Ɠ����ʒu�ɂ��邽�߂̉��ʂ��v�Z
                    double change_volume = System.Convert.ToDouble(standard_label.Text) / 100.0d * 200.0d - peak_pb.Value;
                    // real_trackBar.Value = (int)(((change_volume + (double)peak_pb.Value) / 200.0d) * 100);
                    real_trackBar.Value = (int)(GetVolume() + peak_pb.Value) / 2;
                    real_trackbar_label.Text = System.Convert.ToString(real_trackBar.Value);
                    

                    //Debug.WriteLine("a:" + a + ",b:" + b + ",change_volume:" + change_volume);
                    //Debug.WriteLine("change_volume:" + change_volume);

                    
                    if (change_volume > 0)
                    {
                        SetVolume((int)change_volume);
                        /*
                        // ���ʂ�������
                        if (volume > change_volume)
                        {
                            SetVolume(volume - 1);
                            Debug.WriteLine("��volume:" + volume + " > change_volume:" + change_volume);
                        }
                        // ���ʏグ��
                        else if (volume < change_volume)
                        {
                            SetVolume(volume + 1);
                            Debug.WriteLine("��volume:" + volume + " < change_volume:" + change_volume);
                        }
                        */
                    }
                }

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
            // ���ʂ�ύX�i�͈́F0.00�`1.00�j
            if (volume < 0)
            {
                volume = 0;
            }
            else if (volume > 100)
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