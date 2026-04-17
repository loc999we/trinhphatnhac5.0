namespace trinhphatnhac5._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator = new Guna.UI2.WinForms.Guna2Shapes();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaying = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExplore = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShuffle = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labeCurrentTime = new System.Windows.Forms.Label();
            this.btnVolume = new Guna.UI2.WinForms.Guna2ImageButton();
            this.volume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSort = new Guna.UI2.WinForms.Guna2ImageButton();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.indicator);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnPlaying);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExplore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 1043);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // indicator
            // 
            this.indicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.indicator.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.indicator.Location = new System.Drawing.Point(12, 358);
            this.indicator.Name = "indicator";
            this.indicator.PolygonSkip = 1;
            this.indicator.Rotate = 0F;
            this.indicator.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.indicator.Size = new System.Drawing.Size(33, 59);
            this.indicator.TabIndex = 7;
            this.indicator.Text = "guna2Shapes1";
            this.indicator.Zoom = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelSongTitle);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1565, 88);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelSongTitle
            // 
            this.labelSongTitle.AutoSize = true;
            this.labelSongTitle.Font = new System.Drawing.Font("Book Antiqua", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongTitle.Location = new System.Drawing.Point(19, 16);
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.Size = new System.Drawing.Size(305, 51);
            this.labelSongTitle.TabIndex = 3;
            this.labelSongTitle.Text = "SONG TITLE ";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Image = global::trinhphatnhac5._0.Properties.Resources.close;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(1474, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.Size = new System.Drawing.Size(64, 54);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.Location = new System.Drawing.Point(11, 947);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(210, 66);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Helps";
            // 
            // btnPlaying
            // 
            this.btnPlaying.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnPlaying.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnPlaying.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaying.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaying.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaying.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaying.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnPlaying.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPlaying.ForeColor = System.Drawing.Color.Black;
            this.btnPlaying.Location = new System.Drawing.Point(3, 351);
            this.btnPlaying.Name = "btnPlaying";
            this.btnPlaying.Size = new System.Drawing.Size(210, 66);
            this.btnPlaying.TabIndex = 3;
            this.btnPlaying.Text = "Playing";
            this.btnPlaying.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Premium";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trinhphatnhac5._0.Properties.Resources.itunes;
            this.pictureBox1.Location = new System.Drawing.Point(29, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnExplore
            // 
            this.btnExplore.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnExplore.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnExplore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExplore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExplore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExplore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExplore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnExplore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExplore.ForeColor = System.Drawing.Color.Black;
            this.btnExplore.Location = new System.Drawing.Point(6, 439);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(210, 66);
            this.btnExplore.TabIndex = 5;
            this.btnExplore.Text = "Explore";
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.btnSort);
            this.panel3.Controls.Add(this.btnShuffle);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.labeCurrentTime);
            this.panel3.Controls.Add(this.btnVolume);
            this.panel3.Controls.Add(this.volume);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.guna2ImageButton5);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.TrackBar1);
            this.panel3.Location = new System.Drawing.Point(227, 898);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1557, 145);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnShuffle
            // 
            this.btnShuffle.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShuffle.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShuffle.Image = global::trinhphatnhac5._0.Properties.Resources.shuffle;
            this.btnShuffle.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnShuffle.ImageRotate = 0F;
            this.btnShuffle.ImageSize = new System.Drawing.Size(74, 74);
            this.btnShuffle.Location = new System.Drawing.Point(338, 52);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnShuffle.Size = new System.Drawing.Size(90, 74);
            this.btnShuffle.TabIndex = 20;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.Image = global::trinhphatnhac5._0.Properties.Resources.trash__1_;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(74, 74);
            this.btnDelete.Location = new System.Drawing.Point(195, 49);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.Size = new System.Drawing.Size(90, 74);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1367, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "00:00";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // labeCurrentTime
            // 
            this.labeCurrentTime.AutoSize = true;
            this.labeCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeCurrentTime.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labeCurrentTime.Location = new System.Drawing.Point(73, 15);
            this.labeCurrentTime.Name = "labeCurrentTime";
            this.labeCurrentTime.Size = new System.Drawing.Size(82, 31);
            this.labeCurrentTime.TabIndex = 15;
            this.labeCurrentTime.Text = "00:00";
            this.labeCurrentTime.Click += new System.EventHandler(this.labeCurrentTime_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolume.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolume.Image = global::trinhphatnhac5._0.Properties.Resources.volume;
            this.btnVolume.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnVolume.ImageRotate = 0F;
            this.btnVolume.Location = new System.Drawing.Point(1140, 62);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnVolume.Size = new System.Drawing.Size(78, 66);
            this.btnVolume.TabIndex = 14;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(1240, 69);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(253, 46);
            this.volume.TabIndex = 12;
            this.volume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.volume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.Image = global::trinhphatnhac5._0.Properties.Resources.next;
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(74, 74);
            this.btnNext.Location = new System.Drawing.Point(921, 54);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.Size = new System.Drawing.Size(81, 74);
            this.btnNext.TabIndex = 11;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Image = global::trinhphatnhac5._0.Properties.Resources.play;
            this.guna2ImageButton5.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton5.ImageRotate = 0F;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(94, 94);
            this.guna2ImageButton5.Location = new System.Drawing.Point(691, 35);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton5.Size = new System.Drawing.Size(142, 106);
            this.guna2ImageButton5.TabIndex = 10;
            this.guna2ImageButton5.Click += new System.EventHandler(this.btnPlay);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.Image = global::trinhphatnhac5._0.Properties.Resources._7480582;
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(74, 74);
            this.btnBack.Location = new System.Drawing.Point(503, 52);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.Size = new System.Drawing.Size(90, 74);
            this.btnBack.TabIndex = 8;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(213, 1);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(1105, 45);
            this.TrackBar1.TabIndex = 6;
            this.TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar1_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1562, 846);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Playlists";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2PictureBox1);
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1562, 846);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Playing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1559, 967);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::trinhphatnhac5._0.Properties.Resources.videoframe_4451;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = null;
            this.guna2PictureBox1.Location = new System.Drawing.Point(557, 212);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(459, 445);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TrackList);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnSelect);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1562, 846);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Explore";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(0, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(224, 81);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Thêm bài hát";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClear.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClear.Image = global::trinhphatnhac5._0.Properties.Resources.clear;
            this.btnClear.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClear.ImageRotate = 0F;
            this.btnClear.Location = new System.Drawing.Point(266, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClear.Size = new System.Drawing.Size(84, 84);
            this.btnClear.TabIndex = 18;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSort
            // 
            this.btnSort.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSort.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSort.Image = global::trinhphatnhac5._0.Properties.Resources.sorting;
            this.btnSort.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSort.ImageRotate = 0F;
            this.btnSort.ImageSize = new System.Drawing.Size(74, 74);
            this.btnSort.Location = new System.Drawing.Point(65, 52);
            this.btnSort.Name = "btnSort";
            this.btnSort.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSort.Size = new System.Drawing.Size(90, 74);
            this.btnSort.TabIndex = 19;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // TrackList
            // 
            this.TrackList.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackList.FormattingEnabled = true;
            this.TrackList.ItemHeight = 49;
            this.TrackList.Location = new System.Drawing.Point(3, 80);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(1556, 739);
            this.TrackList.TabIndex = 2;
            this.TrackList.Click += new System.EventHandler(this.TrackList_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(214, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1578, 893);
            this.tabControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1792, 1043);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPlaying;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnExplore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar1;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2TrackBar volume;
        private Guna.UI2.WinForms.Guna2ImageButton btnVolume;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label labelSongTitle;
        private Guna.UI2.WinForms.Guna2Shapes indicator;
        private System.Windows.Forms.Label labeCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private Guna.UI2.WinForms.Guna2ImageButton btnShuffle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2ImageButton btnSort;
        private Guna.UI2.WinForms.Guna2ImageButton btnClear;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

