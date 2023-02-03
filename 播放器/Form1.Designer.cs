namespace 播放器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrevBtn = new System.Windows.Forms.Button();
            this.OpenDirBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SeqPlayBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.LocalVideoBtn = new System.Windows.Forms.Button();
            this.SearchAudioBtn = new System.Windows.Forms.Button();
            this.NetVedioBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.StartLbl = new System.Windows.Forms.Label();
            this.EndLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.LyricsLbl = new System.Windows.Forms.Label();
            this.SongLbl = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.VolumnLbl = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TranslateLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(13, 527);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(85, 30);
            this.PrevBtn.TabIndex = 0;
            this.PrevBtn.Text = "上一曲";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // OpenDirBtn
            // 
            this.OpenDirBtn.Location = new System.Drawing.Point(608, 527);
            this.OpenDirBtn.Name = "OpenDirBtn";
            this.OpenDirBtn.Size = new System.Drawing.Size(85, 30);
            this.OpenDirBtn.TabIndex = 1;
            this.OpenDirBtn.Text = "打开目录";
            this.OpenDirBtn.UseVisualStyleBackColor = true;
            this.OpenDirBtn.Click += new System.EventHandler(this.OpenDirBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(489, 528);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(85, 30);
            this.OpenFileBtn.TabIndex = 2;
            this.OpenFileBtn.Text = "打开文件";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // SeqPlayBtn
            // 
            this.SeqPlayBtn.Location = new System.Drawing.Point(370, 527);
            this.SeqPlayBtn.Name = "SeqPlayBtn";
            this.SeqPlayBtn.Size = new System.Drawing.Size(85, 30);
            this.SeqPlayBtn.TabIndex = 3;
            this.SeqPlayBtn.Text = "顺序播放";
            this.SeqPlayBtn.UseVisualStyleBackColor = true;
            this.SeqPlayBtn.Click += new System.EventHandler(this.SeqPlayBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(251, 527);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(85, 30);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "下一曲";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(132, 527);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(85, 30);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "播放";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // LocalVideoBtn
            // 
            this.LocalVideoBtn.Location = new System.Drawing.Point(13, 13);
            this.LocalVideoBtn.Name = "LocalVideoBtn";
            this.LocalVideoBtn.Size = new System.Drawing.Size(85, 30);
            this.LocalVideoBtn.TabIndex = 6;
            this.LocalVideoBtn.Text = "本地视频";
            this.LocalVideoBtn.UseVisualStyleBackColor = true;
            this.LocalVideoBtn.Click += new System.EventHandler(this.LocalVideoBtn_Click);
            // 
            // SearchAudioBtn
            // 
            this.SearchAudioBtn.Location = new System.Drawing.Point(13, 109);
            this.SearchAudioBtn.Name = "SearchAudioBtn";
            this.SearchAudioBtn.Size = new System.Drawing.Size(85, 30);
            this.SearchAudioBtn.TabIndex = 7;
            this.SearchAudioBtn.Text = "搜索歌曲";
            this.SearchAudioBtn.UseVisualStyleBackColor = true;
            this.SearchAudioBtn.Click += new System.EventHandler(this.SearchAudioBtn_Click);
            // 
            // NetVedioBtn
            // 
            this.NetVedioBtn.Location = new System.Drawing.Point(13, 61);
            this.NetVedioBtn.Name = "NetVedioBtn";
            this.NetVedioBtn.Size = new System.Drawing.Size(85, 30);
            this.NetVedioBtn.TabIndex = 8;
            this.NetVedioBtn.Text = "网络视频";
            this.NetVedioBtn.UseVisualStyleBackColor = true;
            this.NetVedioBtn.Click += new System.EventHandler(this.NetVedioBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 20);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 21);
            this.textBox1.TabIndex = 10;
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(104, 115);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(610, 21);
            this.SearchTb.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(775, 220);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // StartLbl
            // 
            this.StartLbl.AutoSize = true;
            this.StartLbl.Location = new System.Drawing.Point(12, 487);
            this.StartLbl.Name = "StartLbl";
            this.StartLbl.Size = new System.Drawing.Size(41, 12);
            this.StartLbl.TabIndex = 12;
            this.StartLbl.Text = "00：00";
            // 
            // EndLbl
            // 
            this.EndLbl.AutoSize = true;
            this.EndLbl.Location = new System.Drawing.Point(653, 487);
            this.EndLbl.Name = "EndLbl";
            this.EndLbl.Size = new System.Drawing.Size(41, 12);
            this.EndLbl.TabIndex = 12;
            this.EndLbl.Text = "00：00";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 488);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 10);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "正在播放：";
            // 
            // LyricsLbl
            // 
            this.LyricsLbl.AutoSize = true;
            this.LyricsLbl.Location = new System.Drawing.Point(356, 397);
            this.LyricsLbl.Name = "LyricsLbl";
            this.LyricsLbl.Size = new System.Drawing.Size(53, 12);
            this.LyricsLbl.TabIndex = 12;
            this.LyricsLbl.Text = "歌词显示";
            // 
            // SongLbl
            // 
            this.SongLbl.AutoSize = true;
            this.SongLbl.Location = new System.Drawing.Point(83, 456);
            this.SongLbl.Name = "SongLbl";
            this.SongLbl.Size = new System.Drawing.Size(41, 12);
            this.SongLbl.TabIndex = 12;
            this.SongLbl.Text = "未播放";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(743, 456);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 104);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // VolumnLbl
            // 
            this.VolumnLbl.AutoSize = true;
            this.VolumnLbl.Location = new System.Drawing.Point(752, 441);
            this.VolumnLbl.Name = "VolumnLbl";
            this.VolumnLbl.Size = new System.Drawing.Size(23, 12);
            this.VolumnLbl.TabIndex = 12;
            this.VolumnLbl.Text = "20%";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(132, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(351, 38);
            this.axWindowsMediaPlayer1.TabIndex = 15;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TranslateLbl
            // 
            this.TranslateLbl.AutoSize = true;
            this.TranslateLbl.Location = new System.Drawing.Point(368, 429);
            this.TranslateLbl.Name = "TranslateLbl";
            this.TranslateLbl.Size = new System.Drawing.Size(29, 12);
            this.TranslateLbl.TabIndex = 12;
            this.TranslateLbl.Text = "翻译";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.EndLbl);
            this.Controls.Add(this.SongLbl);
            this.Controls.Add(this.TranslateLbl);
            this.Controls.Add(this.LyricsLbl);
            this.Controls.Add(this.VolumnLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NetVedioBtn);
            this.Controls.Add(this.SearchAudioBtn);
            this.Controls.Add(this.LocalVideoBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.SeqPlayBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.OpenDirBtn);
            this.Controls.Add(this.PrevBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "播放器";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button OpenDirBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button SeqPlayBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button LocalVideoBtn;
        private System.Windows.Forms.Button SearchAudioBtn;
        private System.Windows.Forms.Button NetVedioBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label StartLbl;
        private System.Windows.Forms.Label EndLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LyricsLbl;
        private System.Windows.Forms.Label SongLbl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label VolumnLbl;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TranslateLbl;
    }
}

