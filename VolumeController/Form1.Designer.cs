namespace VolumeController
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.volume_label = new System.Windows.Forms.Label();
            this.peak_pb = new System.Windows.Forms.ProgressBar();
            this.devices_cmb = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.label = new System.Windows.Forms.Label();
            this.standard_label = new System.Windows.Forms.Label();
            this.standard_trackBar = new System.Windows.Forms.TrackBar();
            this.media_btn = new System.Windows.Forms.Button();
            this.progres_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.standard_set_btn = new System.Windows.Forms.Button();
            this.real_trackBar = new System.Windows.Forms.TrackBar();
            this.active_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.real_trackBar_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standard_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "現在の音量：";
            // 
            // volume_label
            // 
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(114, 9);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(17, 20);
            this.volume_label.TabIndex = 2;
            this.volume_label.Text = "0";
            // 
            // peak_pb
            // 
            this.peak_pb.Location = new System.Drawing.Point(11, 235);
            this.peak_pb.Name = "peak_pb";
            this.peak_pb.Size = new System.Drawing.Size(600, 73);
            this.peak_pb.TabIndex = 4;
            // 
            // devices_cmb
            // 
            this.devices_cmb.FormattingEnabled = true;
            this.devices_cmb.Location = new System.Drawing.Point(171, 199);
            this.devices_cmb.Name = "devices_cmb";
            this.devices_cmb.Size = new System.Drawing.Size(430, 28);
            this.devices_cmb.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Location = new System.Drawing.Point(170, 9);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(333, 56);
            this.volume_trackBar.TabIndex = 6;
            this.volume_trackBar.Scroll += new System.EventHandler(this.volume_trackBar_Scroll);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 20);
            this.label.TabIndex = 7;
            this.label.Text = "基準の音量：";
            // 
            // standard_label
            // 
            this.standard_label.AutoSize = true;
            this.standard_label.Location = new System.Drawing.Point(113, 81);
            this.standard_label.Name = "standard_label";
            this.standard_label.Size = new System.Drawing.Size(17, 20);
            this.standard_label.TabIndex = 8;
            this.standard_label.Text = "0";
            // 
            // standard_trackBar
            // 
            this.standard_trackBar.Location = new System.Drawing.Point(170, 71);
            this.standard_trackBar.Maximum = 100;
            this.standard_trackBar.Name = "standard_trackBar";
            this.standard_trackBar.Size = new System.Drawing.Size(333, 56);
            this.standard_trackBar.TabIndex = 9;
            this.standard_trackBar.Scroll += new System.EventHandler(this.standard_trackBar_Scroll);
            // 
            // media_btn
            // 
            this.media_btn.Location = new System.Drawing.Point(509, 81);
            this.media_btn.Name = "media_btn";
            this.media_btn.Size = new System.Drawing.Size(94, 29);
            this.media_btn.TabIndex = 11;
            this.media_btn.Text = "サンプル再生";
            this.media_btn.UseVisualStyleBackColor = true;
            this.media_btn.Click += new System.EventHandler(this.media_btn_Click);
            // 
            // progres_value
            // 
            this.progres_value.AutoSize = true;
            this.progres_value.Location = new System.Drawing.Point(120, 199);
            this.progres_value.Name = "progres_value";
            this.progres_value.Size = new System.Drawing.Size(17, 20);
            this.progres_value.TabIndex = 12;
            this.progres_value.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "再生中の音量：";
            // 
            // standard_set_btn
            // 
            this.standard_set_btn.Location = new System.Drawing.Point(509, 133);
            this.standard_set_btn.Name = "standard_set_btn";
            this.standard_set_btn.Size = new System.Drawing.Size(94, 29);
            this.standard_set_btn.TabIndex = 14;
            this.standard_set_btn.Text = "基準を設定";
            this.standard_set_btn.UseVisualStyleBackColor = true;
            this.standard_set_btn.Visible = false;
            this.standard_set_btn.Click += new System.EventHandler(this.standard_set_btn_Click);
            // 
            // real_trackBar
            // 
            this.real_trackBar.Location = new System.Drawing.Point(170, 133);
            this.real_trackBar.Maximum = 100;
            this.real_trackBar.Name = "real_trackBar";
            this.real_trackBar.Size = new System.Drawing.Size(333, 56);
            this.real_trackBar.TabIndex = 15;
            this.real_trackBar.Scroll += new System.EventHandler(this.real_trackBar_Scroll);
            // 
            // active_btn
            // 
            this.active_btn.Location = new System.Drawing.Point(509, 16);
            this.active_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.active_btn.Name = "active_btn";
            this.active_btn.Size = new System.Drawing.Size(94, 31);
            this.active_btn.TabIndex = 16;
            this.active_btn.Text = "停止";
            this.active_btn.UseVisualStyleBackColor = true;
            this.active_btn.Click += new System.EventHandler(this.active_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "音量の範囲：";
            // 
            // real_trackBar_label
            // 
            this.real_trackBar_label.AutoSize = true;
            this.real_trackBar_label.Location = new System.Drawing.Point(113, 142);
            this.real_trackBar_label.Name = "real_trackBar_label";
            this.real_trackBar_label.Size = new System.Drawing.Size(17, 20);
            this.real_trackBar_label.TabIndex = 18;
            this.real_trackBar_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 323);
            this.Controls.Add(this.real_trackBar_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.active_btn);
            this.Controls.Add(this.real_trackBar);
            this.Controls.Add(this.standard_set_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progres_value);
            this.Controls.Add(this.media_btn);
            this.Controls.Add(this.standard_trackBar);
            this.Controls.Add(this.standard_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.volume_trackBar);
            this.Controls.Add(this.devices_cmb);
            this.Controls.Add(this.peak_pb);
            this.Controls.Add(this.volume_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standard_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label volume_label;
        private ProgressBar peak_pb;
        private ComboBox devices_cmb;
        private System.Windows.Forms.Timer timer1;
        private TrackBar volume_trackBar;
        private Label label;
        private Label standard_label;
        private TrackBar standard_trackBar;
        private Button media_btn;
        private Label progres_value;
        private Label label5;
        private Button standard_set_btn;
        private TrackBar real_trackBar;
        private Button active_btn;
        private Label label2;
        private Label real_trackBar_label;
    }
}