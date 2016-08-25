using System;
using System.Windows.Forms;

namespace SoundMixer
{
    partial class MainForm
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

        /// <summary>
        /// Make the window draggable without a border.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.trackBarVolumeDAC = new System.Windows.Forms.TrackBar();
            this.trackBarDefaultVolume = new System.Windows.Forms.TrackBar();
            this.trackFileLocation = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYoutubeAddURL = new System.Windows.Forms.TextBox();
            this.lblErrorMessageYoutubeLInk = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.playList = new System.Windows.Forms.ListView();
            this.songNumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songDurationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progressBarYoutube = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlDevices = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.whatOthersHearVolumeGroupBox = new System.Windows.Forms.GroupBox();
            this.whatYouHearVolumeGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadingIcon = new System.Windows.Forms.PictureBox();
            this.picYouTubePicture = new System.Windows.Forms.PictureBox();
            this.playlistPanel = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumeDAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDefaultVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).BeginInit();
            this.pnlDevices.SuspendLayout();
            this.whatOthersHearVolumeGroupBox.SuspendLayout();
            this.whatYouHearVolumeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).BeginInit();
            this.playlistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.BackColor = System.Drawing.Color.Black;
            this.waveformPainter1.Enabled = false;
            this.waveformPainter1.ForeColor = System.Drawing.Color.White;
            this.waveformPainter1.Location = new System.Drawing.Point(811, 322);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(198, 32);
            this.waveformPainter1.TabIndex = 9;
            this.waveformPainter1.Text = "waveformPainter1";
            this.waveformPainter1.Visible = false;
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.BackColor = System.Drawing.Color.BlueViolet;
            this.volumeMeter1.ForeColor = System.Drawing.Color.White;
            this.volumeMeter1.Location = new System.Drawing.Point(1193, 13);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(28, 317);
            this.volumeMeter1.TabIndex = 8;
            this.volumeMeter1.Text = "volumeMeter1";
            this.volumeMeter1.Visible = false;
            // 
            // trackBarVolumeDAC
            // 
            this.trackBarVolumeDAC.Location = new System.Drawing.Point(2, 19);
            this.trackBarVolumeDAC.Maximum = 100;
            this.trackBarVolumeDAC.Name = "trackBarVolumeDAC";
            this.trackBarVolumeDAC.Size = new System.Drawing.Size(214, 45);
            this.trackBarVolumeDAC.TabIndex = 14;
            this.trackBarVolumeDAC.TickFrequency = 5;
            this.trackBarVolumeDAC.Value = 25;
            this.trackBarVolumeDAC.Scroll += new System.EventHandler(this.trackBarVolumeDAC_Scroll);
            // 
            // trackBarDefaultVolume
            // 
            this.trackBarDefaultVolume.BackColor = System.Drawing.Color.Black;
            this.trackBarDefaultVolume.Location = new System.Drawing.Point(3, 19);
            this.trackBarDefaultVolume.Maximum = 100;
            this.trackBarDefaultVolume.Name = "trackBarDefaultVolume";
            this.trackBarDefaultVolume.Size = new System.Drawing.Size(213, 45);
            this.trackBarDefaultVolume.TabIndex = 14;
            this.trackBarDefaultVolume.TickFrequency = 5;
            this.trackBarDefaultVolume.Value = 25;
            this.trackBarDefaultVolume.Scroll += new System.EventHandler(this.trackBarDefaultVolume_Scroll);
            // 
            // trackFileLocation
            // 
            this.trackFileLocation.BackColor = System.Drawing.Color.Black;
            this.trackFileLocation.Location = new System.Drawing.Point(3, 9);
            this.trackFileLocation.Maximum = 10000;
            this.trackFileLocation.Name = "trackFileLocation";
            this.trackFileLocation.Size = new System.Drawing.Size(546, 45);
            this.trackFileLocation.TabIndex = 14;
            this.trackFileLocation.TickFrequency = 1000;
            this.trackFileLocation.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackFileLocation.Scroll += new System.EventHandler(this.trackFileLocation_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Youtube URL: ";
            // 
            // tbYoutubeAddURL
            // 
            this.tbYoutubeAddURL.BackColor = System.Drawing.Color.GhostWhite;
            this.tbYoutubeAddURL.Location = new System.Drawing.Point(47, 34);
            this.tbYoutubeAddURL.Name = "tbYoutubeAddURL";
            this.tbYoutubeAddURL.Size = new System.Drawing.Size(166, 20);
            this.tbYoutubeAddURL.TabIndex = 15;
            // 
            // lblErrorMessageYoutubeLInk
            // 
            this.lblErrorMessageYoutubeLInk.AutoSize = true;
            this.lblErrorMessageYoutubeLInk.ForeColor = System.Drawing.Color.White;
            this.lblErrorMessageYoutubeLInk.Location = new System.Drawing.Point(398, 250);
            this.lblErrorMessageYoutubeLInk.Name = "lblErrorMessageYoutubeLInk";
            this.lblErrorMessageYoutubeLInk.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessageYoutubeLInk.TabIndex = 18;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(524, 170);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(34, 13);
            this.lblTotalTime.TabIndex = 20;
            this.lblTotalTime.Text = "00:00";
            this.lblTotalTime.Click += new System.EventHandler(this.lblTotalTime_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(484, 170);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(34, 13);
            this.lblCurrentTime.TabIndex = 21;
            this.lblCurrentTime.Text = "00:00";
            this.lblCurrentTime.Click += new System.EventHandler(this.lblCurrentTime_Click);
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 250;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.Color.Black;
            this.playList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songNumberCol,
            this.songNameCol,
            this.songDurationCol});
            this.playList.ForeColor = System.Drawing.SystemColors.Info;
            this.playList.FullRowSelect = true;
            this.playList.Location = new System.Drawing.Point(15, 62);
            this.playList.Margin = new System.Windows.Forms.Padding(5);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(198, 181);
            this.playList.TabIndex = 25;
            this.playList.UseCompatibleStateImageBehavior = false;
            this.playList.View = System.Windows.Forms.View.Details;
            // 
            // songNumberCol
            // 
            this.songNumberCol.Text = "#";
            this.songNumberCol.Width = 25;
            // 
            // songNameCol
            // 
            this.songNameCol.Text = "Name";
            this.songNameCol.Width = 104;
            // 
            // songDurationCol
            // 
            this.songDurationCol.Text = "Duration";
            // 
            // progressBarYoutube
            // 
            this.progressBarYoutube.Location = new System.Drawing.Point(23, 47);
            this.progressBarYoutube.Name = "progressBarYoutube";
            this.progressBarYoutube.Size = new System.Drawing.Size(100, 25);
            this.progressBarYoutube.TabIndex = 26;
            this.progressBarYoutube.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(45, 96);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 27;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // pnlDevices
            // 
            this.pnlDevices.Controls.Add(this.label1);
            this.pnlDevices.Controls.Add(this.whatOthersHearVolumeGroupBox);
            this.pnlDevices.Controls.Add(this.whatYouHearVolumeGroupBox);
            this.pnlDevices.Controls.Add(this.pictureBox1);
            this.pnlDevices.Location = new System.Drawing.Point(12, 57);
            this.pnlDevices.Name = "pnlDevices";
            this.pnlDevices.Size = new System.Drawing.Size(243, 259);
            this.pnlDevices.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0.25";
            // 
            // whatOthersHearVolumeGroupBox
            // 
            this.whatOthersHearVolumeGroupBox.Controls.Add(this.trackBarVolumeDAC);
            this.whatOthersHearVolumeGroupBox.ForeColor = System.Drawing.Color.White;
            this.whatOthersHearVolumeGroupBox.Location = new System.Drawing.Point(12, 162);
            this.whatOthersHearVolumeGroupBox.Name = "whatOthersHearVolumeGroupBox";
            this.whatOthersHearVolumeGroupBox.Size = new System.Drawing.Size(219, 69);
            this.whatOthersHearVolumeGroupBox.TabIndex = 32;
            this.whatOthersHearVolumeGroupBox.TabStop = false;
            this.whatOthersHearVolumeGroupBox.Text = "What Others Hear Volume";
            // 
            // whatYouHearVolumeGroupBox
            // 
            this.whatYouHearVolumeGroupBox.Controls.Add(this.trackBarDefaultVolume);
            this.whatYouHearVolumeGroupBox.ForeColor = System.Drawing.Color.White;
            this.whatYouHearVolumeGroupBox.Location = new System.Drawing.Point(12, 62);
            this.whatYouHearVolumeGroupBox.Name = "whatYouHearVolumeGroupBox";
            this.whatYouHearVolumeGroupBox.Size = new System.Drawing.Size(219, 69);
            this.whatYouHearVolumeGroupBox.TabIndex = 31;
            this.whatYouHearVolumeGroupBox.TabStop = false;
            this.whatYouHearVolumeGroupBox.Text = "What You Hear Volume";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SoundMixer.Properties.Resources.settingsIcon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLoading);
            this.panel2.Controls.Add(this.loadingIcon);
            this.panel2.Controls.Add(this.picYouTubePicture);
            this.panel2.Controls.Add(this.progressBarYoutube);
            this.panel2.Location = new System.Drawing.Point(421, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 128);
            this.panel2.TabIndex = 31;
            // 
            // loadingIcon
            // 
            this.loadingIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingIcon.InitialImage = null;
            this.loadingIcon.Location = new System.Drawing.Point(42, 36);
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
            this.picYouTubePicture.Location = new System.Drawing.Point(22, 18);
            this.picYouTubePicture.Name = "picYouTubePicture";
            this.picYouTubePicture.Size = new System.Drawing.Size(101, 95);
            this.picYouTubePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picYouTubePicture.TabIndex = 19;
            this.picYouTubePicture.TabStop = false;
            // 
            // playlistPanel
            // 
            this.playlistPanel.Controls.Add(this.label2);
            this.playlistPanel.Controls.Add(this.tbYoutubeAddURL);
            this.playlistPanel.Controls.Add(this.playList);
            this.playlistPanel.Controls.Add(this.btnOpenFile);
            this.playlistPanel.Location = new System.Drawing.Point(796, 57);
            this.playlistPanel.Name = "playlistPanel";
            this.playlistPanel.Size = new System.Drawing.Size(225, 259);
            this.playlistPanel.TabIndex = 32;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.Image = global::SoundMixer.Properties.Resources.addMusicIcon;
            this.btnOpenFile.Location = new System.Drawing.Point(15, 34);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(26, 20);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFile.TabIndex = 6;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerPanel.Controls.Add(this.panel2);
            this.playerPanel.Controls.Add(this.trackFileLocation);
            this.playerPanel.Location = new System.Drawing.Point(241, 299);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(549, 66);
            this.playerPanel.TabIndex = 33;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(503, 97);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(38, 56);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 0;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(494, 101);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 46);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.White;
            this.volumeSlider.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.volumeSlider.ForeColor = System.Drawing.Color.White;
            this.volumeSlider.Location = new System.Drawing.Point(1062, 329);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(125, 23);
            this.volumeSlider.TabIndex = 34;
            this.volumeSlider.Visible = false;
            this.volumeSlider.Volume = 0F;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SoundMixer.Properties.Resources.minimizeIcon;
            this.pictureBox2.Location = new System.Drawing.Point(952, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::SoundMixer.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(988, 13);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(17, 24);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 37;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SoundMixer.Properties.Resources.backgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1039, 364);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.playlistPanel);
            this.Controls.Add(this.pnlDevices);
            this.Controls.Add(this.lblErrorMessageYoutubeLInk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skype Mixer";
            this.Move += new System.EventHandler(this.MainForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolumeDAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDefaultVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFileLocation)).EndInit();
            this.pnlDevices.ResumeLayout(false);
            this.pnlDevices.PerformLayout();
            this.whatOthersHearVolumeGroupBox.ResumeLayout(false);
            this.whatOthersHearVolumeGroupBox.PerformLayout();
            this.whatYouHearVolumeGroupBox.ResumeLayout(false);
            this.whatYouHearVolumeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouTubePicture)).EndInit();
            this.playlistPanel.ResumeLayout(false);
            this.playlistPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.PictureBox btnOpenFile;
        private NAudio.Gui.VolumeMeter volumeMeter1;
        private NAudio.Gui.WaveformPainter waveformPainter1;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.TrackBar trackFileLocation;
        private System.Windows.Forms.TrackBar trackBarDefaultVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYoutubeAddURL;
        private System.Windows.Forms.Label lblErrorMessageYoutubeLInk;
        private System.Windows.Forms.PictureBox loadingIcon;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.PictureBox picYouTubePicture;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.ListView playList;
        private System.Windows.Forms.ColumnHeader songNameCol;
        private System.Windows.Forms.ColumnHeader songDurationCol;
        private System.Windows.Forms.ColumnHeader songNumberCol;
        private System.Windows.Forms.TrackBar trackBarVolumeDAC;
        private System.Windows.Forms.ProgressBar progressBarYoutube;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Panel pnlDevices;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel playlistPanel;
        private Panel playerPanel;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private GroupBox whatYouHearVolumeGroupBox;
        private GroupBox whatOthersHearVolumeGroupBox;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox closeBtn;
        private PictureBox pictureBox2;
    }
}

