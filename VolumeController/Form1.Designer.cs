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
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.max_volume = new System.Windows.Forms.Label();
            this.max_trackBar = new System.Windows.Forms.TrackBar();
            this.max_btn = new System.Windows.Forms.Button();
            this.media_btn = new System.Windows.Forms.Button();
            this.progres_value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.min_volume = new System.Windows.Forms.Label();
            this.min_trackBar = new System.Windows.Forms.TrackBar();
            this.min_btn = new System.Windows.Forms.Button();
            this.sum_trackBar = new System.Windows.Forms.TrackBar();
            this.root_maxtrackBar = new System.Windows.Forms.TrackBar();
            this.root_mintrackBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.root_maxtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.root_mintrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "現在の音量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 226);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 55);
            this.progressBar1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 183);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Location = new System.Drawing.Point(149, 7);
            this.volume_trackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(291, 45);
            this.volume_trackBar.TabIndex = 6;
            this.volume_trackBar.Scroll += new System.EventHandler(this.volume_trackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "最大の音量：";
            // 
            // max_volume
            // 
            this.max_volume.AutoSize = true;
            this.max_volume.Location = new System.Drawing.Point(100, 61);
            this.max_volume.Name = "max_volume";
            this.max_volume.Size = new System.Drawing.Size(25, 15);
            this.max_volume.TabIndex = 8;
            this.max_volume.Text = "100";
            // 
            // max_trackBar
            // 
            this.max_trackBar.Location = new System.Drawing.Point(148, 78);
            this.max_trackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max_trackBar.Maximum = 100;
            this.max_trackBar.Name = "max_trackBar";
            this.max_trackBar.Size = new System.Drawing.Size(291, 45);
            this.max_trackBar.TabIndex = 9;
            this.max_trackBar.Value = 100;
            this.max_trackBar.Scroll += new System.EventHandler(this.max_trackBar_Scroll);
            // 
            // max_btn
            // 
            this.max_btn.Location = new System.Drawing.Point(12, 78);
            this.max_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max_btn.Name = "max_btn";
            this.max_btn.Size = new System.Drawing.Size(119, 22);
            this.max_btn.TabIndex = 10;
            this.max_btn.Text = "最大の音量に設定";
            this.max_btn.UseVisualStyleBackColor = true;
            this.max_btn.Click += new System.EventHandler(this.max_btn_Click);
            // 
            // media_btn
            // 
            this.media_btn.Location = new System.Drawing.Point(445, 61);
            this.media_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.media_btn.Name = "media_btn";
            this.media_btn.Size = new System.Drawing.Size(82, 22);
            this.media_btn.TabIndex = 11;
            this.media_btn.Text = "play";
            this.media_btn.UseVisualStyleBackColor = true;
            this.media_btn.Click += new System.EventHandler(this.media_btn_Click);
            // 
            // progres_value
            // 
            this.progres_value.AutoSize = true;
            this.progres_value.Location = new System.Drawing.Point(114, 191);
            this.progres_value.Name = "progres_value";
            this.progres_value.Size = new System.Drawing.Size(13, 15);
            this.progres_value.TabIndex = 12;
            this.progres_value.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "再生中の音量：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "最小の音量：";
            // 
            // min_volume
            // 
            this.min_volume.AutoSize = true;
            this.min_volume.Location = new System.Drawing.Point(100, 112);
            this.min_volume.Name = "min_volume";
            this.min_volume.Size = new System.Drawing.Size(13, 15);
            this.min_volume.TabIndex = 15;
            this.min_volume.Text = "0";
            // 
            // min_trackBar
            // 
            this.min_trackBar.Location = new System.Drawing.Point(149, 132);
            this.min_trackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min_trackBar.Maximum = 100;
            this.min_trackBar.Name = "min_trackBar";
            this.min_trackBar.Size = new System.Drawing.Size(291, 45);
            this.min_trackBar.TabIndex = 16;
            this.min_trackBar.Scroll += new System.EventHandler(this.min_trackBar_Scroll);
            // 
            // min_btn
            // 
            this.min_btn.Location = new System.Drawing.Point(14, 132);
            this.min_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min_btn.Name = "min_btn";
            this.min_btn.Size = new System.Drawing.Size(117, 22);
            this.min_btn.TabIndex = 17;
            this.min_btn.Text = "最小の音量に設定";
            this.min_btn.UseVisualStyleBackColor = true;
            this.min_btn.Click += new System.EventHandler(this.min_btn_Click);
            // 
            // sum_trackBar
            // 
            this.sum_trackBar.Location = new System.Drawing.Point(155, 351);
            this.sum_trackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sum_trackBar.Maximum = 100;
            this.sum_trackBar.Name = "sum_trackBar";
            this.sum_trackBar.Size = new System.Drawing.Size(291, 45);
            this.sum_trackBar.TabIndex = 18;
            // 
            // root_maxtrackBar
            // 
            this.root_maxtrackBar.Location = new System.Drawing.Point(155, 301);
            this.root_maxtrackBar.Maximum = 100;
            this.root_maxtrackBar.Name = "root_maxtrackBar";
            this.root_maxtrackBar.Size = new System.Drawing.Size(287, 45);
            this.root_maxtrackBar.TabIndex = 19;
            // 
            // root_mintrackBar
            // 
            this.root_mintrackBar.Location = new System.Drawing.Point(155, 401);
            this.root_mintrackBar.Maximum = 100;
            this.root_mintrackBar.Name = "root_mintrackBar";
            this.root_mintrackBar.Size = new System.Drawing.Size(287, 45);
            this.root_mintrackBar.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "かけた最大音量";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "かけた最小音量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "最大と最小の間";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 458);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.root_mintrackBar);
            this.Controls.Add(this.root_maxtrackBar);
            this.Controls.Add(this.sum_trackBar);
            this.Controls.Add(this.min_btn);
            this.Controls.Add(this.min_trackBar);
            this.Controls.Add(this.min_volume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progres_value);
            this.Controls.Add(this.media_btn);
            this.Controls.Add(this.max_btn);
            this.Controls.Add(this.max_trackBar);
            this.Controls.Add(this.max_volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volume_trackBar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sum_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.root_maxtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.root_mintrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar volume_trackBar;
        private Label label3;
        private Label max_volume;
        private TrackBar max_trackBar;
        private Button max_btn;
        private Button media_btn;
        private Label progres_value;
        private Label label5;
        private Label label6;
        private Label min_volume;
        private TrackBar min_trackBar;
        private Button min_btn;
        private TrackBar sum_trackBar;
        private TrackBar root_maxtrackBar;
        private TrackBar root_mintrackBar;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}