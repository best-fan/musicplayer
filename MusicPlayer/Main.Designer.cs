namespace MusicPlayer
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LrcLbl = new System.Windows.Forms.Label();
            this.PlayModeLbl = new System.Windows.Forms.Label();
            this.SongLbl = new System.Windows.Forms.Label();
            this.SingerLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MusicDgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.删除歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MusicNumLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.NowTimeLbl = new System.Windows.Forms.Label();
            this.PlayTimeLbl = new System.Windows.Forms.Label();
            this.VolumTrackBar = new System.Windows.Forms.TrackBar();
            this.Musictimer = new System.Windows.Forms.Timer(this.components);
            this.Lrc_picbox = new System.Windows.Forms.PictureBox();
            this.PlayModePicbox = new System.Windows.Forms.PictureBox();
            this.Soundpicbox = new System.Windows.Forms.PictureBox();
            this.Nextpicbox = new System.Windows.Forms.PictureBox();
            this.Prepicbox = new System.Windows.Forms.PictureBox();
            this.Playpicbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lrc_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayModePicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soundpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prepicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LrcLbl);
            this.panel1.Controls.Add(this.PlayModeLbl);
            this.panel1.Controls.Add(this.SongLbl);
            this.panel1.Controls.Add(this.SingerLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 343);
            this.panel1.TabIndex = 0;
            // 
            // LrcLbl
            // 
            this.LrcLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LrcLbl.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LrcLbl.ForeColor = System.Drawing.Color.Yellow;
            this.LrcLbl.Location = new System.Drawing.Point(0, 167);
            this.LrcLbl.Name = "LrcLbl";
            this.LrcLbl.Size = new System.Drawing.Size(476, 41);
            this.LrcLbl.TabIndex = 11;
            this.LrcLbl.Text = "label1";
            this.LrcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LrcLbl.Visible = false;
            // 
            // PlayModeLbl
            // 
            this.PlayModeLbl.AutoSize = true;
            this.PlayModeLbl.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold);
            this.PlayModeLbl.ForeColor = System.Drawing.Color.Cyan;
            this.PlayModeLbl.Location = new System.Drawing.Point(269, 18);
            this.PlayModeLbl.Name = "PlayModeLbl";
            this.PlayModeLbl.Size = new System.Drawing.Size(161, 16);
            this.PlayModeLbl.TabIndex = 10;
            this.PlayModeLbl.Text = "播放模式：顺序播放";
            // 
            // SongLbl
            // 
            this.SongLbl.AutoSize = true;
            this.SongLbl.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold);
            this.SongLbl.Location = new System.Drawing.Point(7, 49);
            this.SongLbl.Name = "SongLbl";
            this.SongLbl.Size = new System.Drawing.Size(59, 16);
            this.SongLbl.TabIndex = 7;
            this.SongLbl.Text = "歌曲：";
            // 
            // SingerLbl
            // 
            this.SingerLbl.AutoSize = true;
            this.SingerLbl.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SingerLbl.Location = new System.Drawing.Point(7, 18);
            this.SingerLbl.Name = "SingerLbl";
            this.SingerLbl.Size = new System.Drawing.Size(59, 16);
            this.SingerLbl.TabIndex = 8;
            this.SingerLbl.Text = "歌手：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MusicDgv);
            this.panel3.Location = new System.Drawing.Point(500, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 461);
            this.panel3.TabIndex = 2;
            // 
            // MusicDgv
            // 
            this.MusicDgv.AllowUserToAddRows = false;
            this.MusicDgv.AllowUserToDeleteRows = false;
            this.MusicDgv.AllowUserToResizeColumns = false;
            this.MusicDgv.AllowUserToResizeRows = false;
            this.MusicDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MusicDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MusicDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微软雅黑 Light", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicDgv.DefaultCellStyle = dataGridViewCellStyle16;
            this.MusicDgv.GridColor = System.Drawing.SystemColors.ControlText;
            this.MusicDgv.Location = new System.Drawing.Point(11, 3);
            this.MusicDgv.Name = "MusicDgv";
            this.MusicDgv.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusicDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.MusicDgv.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.DarkTurquoise;
            this.MusicDgv.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.MusicDgv.RowTemplate.Height = 23;
            this.MusicDgv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MusicDgv.Size = new System.Drawing.Size(185, 458);
            this.MusicDgv.TabIndex = 0;
            this.MusicDgv.DoubleClick += new System.EventHandler(this.MusicDgv_DoubleClick);
            this.MusicDgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicDgv_MouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "歌曲";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 143;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "格式";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "链接";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "歌手";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "歌曲";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.打开ToolStripMenuItem,
            this.toolStripSeparator2,
            this.清空列表ToolStripMenuItem,
            this.toolStripSeparator3,
            this.删除歌曲ToolStripMenuItem,
            this.toolStripSeparator4,
            this.使用说明ToolStripMenuItem,
            this.toolStripSeparator5,
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 144);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.打开ToolStripMenuItem.Text = "打开文件";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(96, 6);
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(96, 6);
            // 
            // 删除歌曲ToolStripMenuItem
            // 
            this.删除歌曲ToolStripMenuItem.Name = "删除歌曲ToolStripMenuItem";
            this.删除歌曲ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.删除歌曲ToolStripMenuItem.Text = "删除歌曲";
            this.删除歌曲ToolStripMenuItem.Click += new System.EventHandler(this.删除歌曲ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(96, 6);
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(96, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.关闭ToolStripMenuItem.Text = "退出";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.Lrc_picbox);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.PlayModePicbox);
            this.panel2.Controls.Add(this.Soundpicbox);
            this.panel2.Controls.Add(this.MusicNumLbl);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.Nextpicbox);
            this.panel2.Controls.Add(this.Prepicbox);
            this.panel2.Controls.Add(this.Playpicbox);
            this.panel2.Controls.Add(this.NowTimeLbl);
            this.panel2.Controls.Add(this.PlayTimeLbl);
            this.panel2.Controls.Add(this.VolumTrackBar);
            this.panel2.Location = new System.Drawing.Point(12, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 100);
            this.panel2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(180)))));
            this.linkLabel1.Font = new System.Drawing.Font("SketchFlow Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel1.Location = new System.Drawing.Point(395, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Join Us";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MusicNumLbl
            // 
            this.MusicNumLbl.AutoSize = true;
            this.MusicNumLbl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicNumLbl.Location = new System.Drawing.Point(395, 81);
            this.MusicNumLbl.Name = "MusicNumLbl";
            this.MusicNumLbl.Size = new System.Drawing.Size(65, 12);
            this.MusicNumLbl.TabIndex = 7;
            this.MusicNumLbl.Text = "列表歌曲：";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Info;
            this.progressBar1.Location = new System.Drawing.Point(92, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(297, 12);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // NowTimeLbl
            // 
            this.NowTimeLbl.AutoSize = true;
            this.NowTimeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NowTimeLbl.Location = new System.Drawing.Point(51, 24);
            this.NowTimeLbl.Name = "NowTimeLbl";
            this.NowTimeLbl.Size = new System.Drawing.Size(35, 12);
            this.NowTimeLbl.TabIndex = 5;
            this.NowTimeLbl.Text = "00:00";
            // 
            // PlayTimeLbl
            // 
            this.PlayTimeLbl.AutoSize = true;
            this.PlayTimeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayTimeLbl.Location = new System.Drawing.Point(395, 24);
            this.PlayTimeLbl.Name = "PlayTimeLbl";
            this.PlayTimeLbl.Size = new System.Drawing.Size(35, 12);
            this.PlayTimeLbl.TabIndex = 4;
            this.PlayTimeLbl.Text = "00:00";
            // 
            // VolumTrackBar
            // 
            this.VolumTrackBar.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.VolumTrackBar.Location = new System.Drawing.Point(3, 0);
            this.VolumTrackBar.Maximum = 100;
            this.VolumTrackBar.Name = "VolumTrackBar";
            this.VolumTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumTrackBar.Size = new System.Drawing.Size(45, 73);
            this.VolumTrackBar.SmallChange = 10;
            this.VolumTrackBar.TabIndex = 3;
            this.VolumTrackBar.TickFrequency = 10;
            this.VolumTrackBar.Value = 100;
            this.VolumTrackBar.Visible = false;
            this.VolumTrackBar.Scroll += new System.EventHandler(this.VolumTrackBar_Scroll);
            // 
            // Musictimer
            // 
            this.Musictimer.Tick += new System.EventHandler(this.Musictimer_Tick);
            // 
            // Lrc_picbox
            // 
            this.Lrc_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Lrc_picbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lrc_picbox.Image = global::MusicPlayer.Properties.Resources.Lrc;
            this.Lrc_picbox.Location = new System.Drawing.Point(72, 63);
            this.Lrc_picbox.Name = "Lrc_picbox";
            this.Lrc_picbox.Size = new System.Drawing.Size(30, 30);
            this.Lrc_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lrc_picbox.TabIndex = 11;
            this.Lrc_picbox.TabStop = false;
            this.Lrc_picbox.Click += new System.EventHandler(this.Lrc_picbox_Click);
            this.Lrc_picbox.MouseLeave += new System.EventHandler(this.Lrc_picbox_MouseLeave);
            this.Lrc_picbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lrc_picbox_MouseMove);
            // 
            // PlayModePicbox
            // 
            this.PlayModePicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayModePicbox.Image = global::MusicPlayer.Properties.Resources.order;
            this.PlayModePicbox.Location = new System.Drawing.Point(355, 63);
            this.PlayModePicbox.Name = "PlayModePicbox";
            this.PlayModePicbox.Size = new System.Drawing.Size(34, 30);
            this.PlayModePicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayModePicbox.TabIndex = 9;
            this.PlayModePicbox.TabStop = false;
            this.PlayModePicbox.Click += new System.EventHandler(this.PlayModePicbox_Click);
            this.PlayModePicbox.MouseLeave += new System.EventHandler(this.PlayModePicbox_MouseLeave);
            this.PlayModePicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayModePicbox_MouseMove);
            // 
            // Soundpicbox
            // 
            this.Soundpicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Soundpicbox.Image = global::MusicPlayer.Properties.Resources.sound;
            this.Soundpicbox.Location = new System.Drawing.Point(36, 63);
            this.Soundpicbox.Name = "Soundpicbox";
            this.Soundpicbox.Size = new System.Drawing.Size(30, 30);
            this.Soundpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Soundpicbox.TabIndex = 8;
            this.Soundpicbox.TabStop = false;
            this.Soundpicbox.Click += new System.EventHandler(this.Soundpicbox_Click);
            this.Soundpicbox.MouseLeave += new System.EventHandler(this.Soundpicbox_MouseLeave);
            this.Soundpicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Soundpicbox_MouseMove);
            // 
            // Nextpicbox
            // 
            this.Nextpicbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nextpicbox.BackgroundImage")));
            this.Nextpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nextpicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nextpicbox.Image = global::MusicPlayer.Properties.Resources.next;
            this.Nextpicbox.Location = new System.Drawing.Point(295, 63);
            this.Nextpicbox.Name = "Nextpicbox";
            this.Nextpicbox.Size = new System.Drawing.Size(30, 30);
            this.Nextpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nextpicbox.TabIndex = 2;
            this.Nextpicbox.TabStop = false;
            this.Nextpicbox.Click += new System.EventHandler(this.Nextpicbox_Click);
            this.Nextpicbox.MouseLeave += new System.EventHandler(this.Nextpicbox_MouseLeave);
            this.Nextpicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nextpicbox_MouseMove);
            // 
            // Prepicbox
            // 
            this.Prepicbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Prepicbox.BackgroundImage")));
            this.Prepicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Prepicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Prepicbox.Image = global::MusicPlayer.Properties.Resources.pre;
            this.Prepicbox.Location = new System.Drawing.Point(146, 63);
            this.Prepicbox.Name = "Prepicbox";
            this.Prepicbox.Size = new System.Drawing.Size(30, 30);
            this.Prepicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Prepicbox.TabIndex = 1;
            this.Prepicbox.TabStop = false;
            this.Prepicbox.Click += new System.EventHandler(this.Prepicbox_Click);
            this.Prepicbox.MouseLeave += new System.EventHandler(this.Prepicbox_MouseLeave);
            this.Prepicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Prepicbox_MouseMove);
            // 
            // Playpicbox
            // 
            this.Playpicbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Playpicbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Playpicbox.Image = global::MusicPlayer.Properties.Resources.play;
            this.Playpicbox.Location = new System.Drawing.Point(218, 60);
            this.Playpicbox.Name = "Playpicbox";
            this.Playpicbox.Size = new System.Drawing.Size(33, 33);
            this.Playpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Playpicbox.TabIndex = 0;
            this.Playpicbox.TabStop = false;
            this.Playpicbox.Click += new System.EventHandler(this.Playpicbox_Click);
            this.Playpicbox.MouseLeave += new System.EventHandler(this.Playpicbox_MouseLeave);
            this.Playpicbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Playpicbox_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(114)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(712, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music_Play 小樊工作室出品";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lrc_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayModePicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soundpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nextpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prepicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playpicbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 删除歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Nextpicbox;
        private System.Windows.Forms.PictureBox Prepicbox;
        private System.Windows.Forms.PictureBox Playpicbox;
        private System.Windows.Forms.TrackBar VolumTrackBar;
        private System.Windows.Forms.Label PlayTimeLbl;
        private System.Windows.Forms.Timer Musictimer;
        private System.Windows.Forms.Label NowTimeLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView MusicDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label SingerLbl;
        private System.Windows.Forms.Label SongLbl;
        private System.Windows.Forms.Label MusicNumLbl;
        private System.Windows.Forms.PictureBox Soundpicbox;
        private System.Windows.Forms.PictureBox PlayModePicbox;
        private System.Windows.Forms.Label PlayModeLbl;
        private System.Windows.Forms.Label LrcLbl;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox Lrc_picbox;
    }
}