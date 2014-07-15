namespace SoundWiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbInputDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.lblSoundFile = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.trackFileLocation = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.listYoutubeMP3s = new System.Windows.Forms.ListBox();
            this.tbYoutubeAddURL = new System.Windows.Forms.TextBox();
            this.lblErrorMessageYoutubeLInk = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.loadingIcon = new System.Windows.Forms.PictureBox();
            this.picYouTubePicture = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInputDevices
            // 
            this.cbInputDevices.BackColor = System.Drawing.Color.GreenYellow;
            this.cbInputDevices.FormattingEnabled = true;
            this.cbInputDevices.Location = new System.Drawing.Point(32, 562);
            this.cbInputDevices.Name = "cbInputDevices";
            this.cbInputDevices.Size = new System.Drawing.Size(170, 21);
            this.cbInputDevices.TabIndex = 1;
            this.cbInputDevices.Text = "Pick Input Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.White;
            this.volumeSlider.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.volumeSlider.ForeColor = System.Drawing.Color.White;
            this.volumeSlider.Location = new System.Drawing.Point(18, 16);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(125, 23);
            this.volumeSlider.TabIndex = 10;
            this.volumeSlider.Volume = 1F;
            this.volumeSlider.VolumeChanged += new System.EventHandler(this.volumeSlider_VolumeChanged);
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.Black;
            this.waveformPainter1.ForeColor = System.Drawing.Color.White;
            this.waveformPainter1.Location = new System.Drawing.Point(595, 3);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(159, 46);
            this.waveformPainter1.TabIndex = 9;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.BackColor = System.Drawing.Color.Black;
            this.volumeMeter1.ForeColor = System.Drawing.Color.White;
            this.volumeMeter1.Location = new System.Drawing.Point(12, 23);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(28, 396);
            this.volumeMeter1.TabIndex = 8;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // lblSoundFile
            // 
            this.lblSoundFile.AutoSize = true;
            this.lblSoundFile.ForeColor = System.Drawing.Color.White;
            this.lblSoundFile.Location = new System.Drawing.Point(487, 609);
            this.lblSoundFile.Name = "lblSoundFile";
            this.lblSoundFile.Size = new System.Drawing.Size(47, 13);
            this.lblSoundFile.TabIndex = 7;
            this.lblSoundFile.Text = "open file";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(938, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Play Sound";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.waveformPainter1);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.volumeSlider);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 56);
            this.panel1.TabIndex = 13;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Image = global::SoundWiz.Properties.Resources.previous;
            this.btnPrevious.Location = new System.Drawing.Point(197, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(54, 46);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::SoundWiz.Properties.Resources.Play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(311, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 46);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::SoundWiz.Properties.Resources.Pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(321, -1);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 56);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::SoundWiz.Properties.Resources.Stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Location = new System.Drawing.Point(267, -2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 56);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStop.TabIndex = 0;
            this.btnStop.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Image = global::SoundWiz.Properties.Resources.Next;
            this.btnNext.Location = new System.Drawing.Point(375, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 46);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 0;
            this.btnNext.TabStop = false;
            // 
            // trackFileLocation
            // 
            this.trackFileLocation.Location = new System.Drawing.Point(32, 439);
            this.trackFileLocation.Maximum = 10000;
            this.trackFileLocation.Name = "trackFileLocation";
            this.trackFileLocation.Size = new System.Drawing.Size(654, 45);
            this.trackFileLocation.TabIndex = 14;
            this.trackFileLocation.TickFrequency = 1000;
            this.trackFileLocation.Scroll += new System.EventHandler(this.trackFileLocation_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(241, 555);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Minimum = 5;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(139, 45);
            this.trackBarVolume.TabIndex = 14;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.Value = 5;
            this.trackBarVolume.Visible = false;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(830, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Youtube URL: ";
            // 
            // listYoutubeMP3s
            // 
            this.listYoutubeMP3s.FormattingEnabled = true;
            this.listYoutubeMP3s.Location = new System.Drawing.Point(833, 64);
            this.listYoutubeMP3s.Name = "listYoutubeMP3s";
            this.listYoutubeMP3s.Size = new System.Drawing.Size(234, 420);
            this.listYoutubeMP3s.TabIndex = 17;
            // 
            // tbYoutubeAddURL
            // 
            this.tbYoutubeAddURL.Location = new System.Drawing.Point(833, 31);
            this.tbYoutubeAddURL.Name = "tbYoutubeAddURL";
            this.tbYoutubeAddURL.Size = new System.Drawing.Size(234, 20);
            this.tbYoutubeAddURL.TabIndex = 15;
            // 
            // lblErrorMessageYoutubeLInk
            // 
            this.lblErrorMessageYoutubeLInk.AutoSize = true;
            this.lblErrorMessageYoutubeLInk.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessageYoutubeLInk.Location = new System.Drawing.Point(394, 205);
            this.lblErrorMessageYoutubeLInk.Name = "lblErrorMessageYoutubeLInk";
            this.lblErrorMessageYoutubeLInk.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessageYoutubeLInk.TabIndex = 18;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(751, 448);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTime.TabIndex = 20;
            this.lblTotalTime.Text = "00:00";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(692, 448);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentTime.TabIndex = 21;
            this.lblCurrentTime.Text = "00:00";
            // 
            // loadingIcon
            // 
            this.loadingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingIcon.InitialImage = null;
            this.loadingIcon.Location = new System.Drawing.Point(377, 181);
            this.loadingIcon.Name = "loadingIcon";
            this.loadingIcon.Size = new System.Drawing.Size(57, 57);
            this.loadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingIcon.TabIndex = 22;
            this.loadingIcon.TabStop = false;
            this.loadingIcon.Visible = false;
            // 
            // picYouTubePicture
            // 
            this.picYouTubePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picYouTubePicture.ImageLocation = "";
            this.picYouTubePicture.Location = new System.Drawing.Point(63, 23);
            this.picYouTubePicture.Name = "picYouTubePicture";
            this.picYouTubePicture.Size = new System.Drawing.Size(730, 396);
            this.picYouTubePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYouTubePicture.TabIndex = 19;
            this.picYouTubePicture.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Image = global::SoundWiz.Properties.Resources.Open;
            this.btnOpenFile.Location = new System.Drawing.Point(804, 33);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(19, 18);
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 500;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1079, 631);
            this.Controls.Add(this.loadingIcon);
            this.Controls.Add(this.lblErrorMessageYoutubeLInk);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.picYouTubePicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listYoutubeMP3s);
            this.Controls.Add(this.tbYoutubeAddURL);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackFileLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbInputDevices);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.lblSoundFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Audio Loopback";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox btnOpenFile;
        private System.Windows.Forms.Label lblSoundFile;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private System.Windows.Forms.ComboBox cbInputDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.TrackBar trackFileLocation;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listYoutubeMP3s;
        private System.Windows.Forms.TextBox tbYoutubeAddURL;
        private System.Windows.Forms.Label lblErrorMessageYoutubeLInk;
        private System.Windows.Forms.PictureBox loadingIcon;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox picYouTubePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.PictureBox btnPause;
    }
}

