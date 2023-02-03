using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;
using NJsonSchema.Extensions;
using Newtonsoft.Json.Linq;

namespace 播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.volume = 20;
            List<Video> listVideo = new List<Video>();
            Video v1 = new Video() { id = "通道1", name = "http://okjx.cc/?url=" };
            Video v2 = new Video() { id = "通道2", name = "http://jx.m3u8.tv/jiexi/?url=" };
            listVideo.Add(v1);
            listVideo.Add(v2);
            comboBox1.DataSource = listVideo;
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "name";
        }

        const string localLyricPath = "C:\\Users\\Micro\\Music\\lrc\\";
        bool lyricStatus = false;
        List<double> lyricTimeList = new List<double>();
        List<string> lyricTextList = new List<string>();

        public List<string> onlineUrlList = new List<string>();
        public List<string> onlineLrcList = new List<string>();

        string[] files, paths;
        string localSelectedPath;
        List<string> localSelectedPathList = new List<string>();

        private void OpenDirBtn_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog vfbd = new VistaFolderBrowserDialog();
            if (vfbd.ShowDialog() == DialogResult.OK)
            {
                localSelectedPathList.Clear();
                listBox1.Items.Clear();
                if (files != null || paths != null)
                {
                    Array.Clear(files, 0, files.Length);
                    Array.Clear(paths, 0, paths.Length);
                }
                localSelectedPath = vfbd.SelectedPath;
                foreach (var item in Directory.GetFiles(localSelectedPath))
                {
                    localSelectedPathList.Add(item);
                    listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (localSelectedPathList.Count > 0)
            {
                axWindowsMediaPlayer1.URL = localSelectedPathList[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                SongLbl.Text = Path.GetFileNameWithoutExtension(localSelectedPathList[listBox1.SelectedIndex]);
            }
            else if (onlineUrlList.Count > 0)
            {
                axWindowsMediaPlayer1.URL = onlineUrlList[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                SongLbl.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
                SongLbl.Text = Path.GetFileNameWithoutExtension(paths[listBox1.SelectedIndex]);
            }

            PlayBtn.Text = "暂停";
            lyricStatus = SplitLyricTimeAmdText();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (PlayBtn.Text == "暂停")
            {
                PlayBtn.Text = "播放";
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                PlayBtn.Text = "暂停";
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex >= 0)
            //{
            //    if (listBox1.SelectedIndex == 0)
            //    {
            //        listBox1.SelectedIndex = listBox1.Items.Count - 1;
            //    }
            //    else
            //    {
            //        listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            //    }
            //}

            PlayMode(true);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            //{
            //    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            //}
            //else
            //{
            //    listBox1.SelectedIndex = 0;
            //}

            PlayMode(false);
        }

        private void SeqPlayBtn_Click(object sender, EventArgs e)
        {
            if (SeqPlayBtn.Text == "顺序播放")
            {
                SeqPlayBtn.Text = "随机播放";
            }
            else if (SeqPlayBtn.Text == "随机播放")
            {
                SeqPlayBtn.Text = "单曲循环";
            }
            else
            {
                SeqPlayBtn.Text = "顺序播放";
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "选择音频|*.mp3; *.flac; *.wav;";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localSelectedPathList.Clear();
                listBox1.Items.Clear();
                if (files != null || paths != null)
                {
                    Array.Clear(files, 0, files.Length);
                    Array.Clear(paths, 0, paths.Length);
                }
                files = ofd.FileNames;
                paths = ofd.FileNames;
                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            VolumnLbl.Text = trackBar1.Value + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                StartLbl.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                EndLbl.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                if (progressBar1.Maximum == progressBar1.Value)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                }
                if (lyricStatus)
                {
                    IsShowLyricText();
                }
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                PlayMode(false);
            }
        }

        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void SearchAudioBtn_Click(object sender, EventArgs e)
        {
            localSelectedPathList.Clear();
            onlineUrlList.Clear();
            onlineLrcList.Clear();
            listBox1.Items.Clear();
            if (files != null || paths != null)
            {
                Array.Clear(files, 0, files.Length);
                Array.Clear(paths, 0, paths.Length);
            }

            string songName = SearchTb.Text.Trim();
            string url = "http://localhost:8080/play?rnd=123456.33";
            string responseContent = string.Empty;
            string postData = "{\"server\":\"1\",\"id\":\"" + songName + "\",\"ip\":\"127,0.0.1\"}";

            try
            {
                HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create(url);
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                hwr.Method = "POST";
                hwr.ContentLength = byteArray.Length;
                hwr.ContentType = "application/json;charset=UTF-8";
                hwr.Headers.Add("x-requested-with", "XMLHttpRequest");
                using (var stream = hwr.GetRequestStream())
                {
                    stream.Write(byteArray, 0, byteArray.Length);
                    stream.Close();
                }

                using (HttpWebResponse response = (HttpWebResponse)hwr.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        responseContent = sr.ReadToEnd();
                        responseContent = "[" + responseContent + "]";
                        JArray jArray = JArray.Parse(responseContent);
                        foreach (var item in jArray)
                        {

                            foreach (var jarr in item["data"])
                            {
                                onlineUrlList.Add(jarr["url"].ToString());
                                onlineLrcList.Add(jarr["lrc"].ToString());
                                listBox1.Items.Add(jarr["title"]);
                            }
                        }
                        Console.WriteLine(responseContent);
                        sr.Close();
                        response.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 播放模式
        public void PlayMode(bool mode)
        {
            if (SeqPlayBtn.Text == "顺序播放")
            {
                if (mode)
                {
                    if (listBox1.SelectedIndex >= 0)
                    {
                        if (listBox1.SelectedIndex == 0)
                        {
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                        }
                        else
                        {
                            listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                        }
                    }
                }
                else
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    {
                        listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    }
                    else
                    {
                        listBox1.SelectedIndex = 0;
                    }
                }
            }
            else if (SeqPlayBtn.Text == "随机播放")
            {
                Random random = new Random();
                int r = random.Next(0, listBox1.Items.Count);
                if (r == listBox1.SelectedIndex)
                {
                    if (r + 1 == listBox1.Items.Count)
                    {
                        r--;
                    }
                    else
                    {
                        r++;
                    }
                }
                if (localSelectedPathList.Count > 0)
                {
                    axWindowsMediaPlayer1.URL = localSelectedPathList[listBox1.SelectedIndex = r];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else if (onlineUrlList.Count > 0)
                {
                    axWindowsMediaPlayer1.URL = onlineUrlList[listBox1.SelectedIndex = r];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex = r];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            else if (SeqPlayBtn.Text == "单曲循环")
            {
                if (localSelectedPathList.Count > 0)
                {
                    axWindowsMediaPlayer1.URL = localSelectedPathList[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else if (onlineUrlList.Count > 0)
                {
                    axWindowsMediaPlayer1.URL = onlineUrlList[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }
        #endregion

        #region 拆分歌词时间和文本
        public bool SplitLyricTimeAmdText()
        {
            try
            {
                string lyricPath = localLyricPath + Path.GetFileNameWithoutExtension(listBox1.SelectedItem.ToString()) + ".lrc";
                if (File.Exists(lyricPath))
                {
                    string[] arrStr = File.ReadAllLines(lyricPath, Encoding.UTF8);
                    double totalCount = 0;
                    foreach (string str in arrStr)
                    {
                        if (Regex.IsMatch(str, @"[0-9][0-9]:[0-9][0-9].[0-9][0-9]"))
                        {
                            Match a = Regex.Match(str, @"[0-9][0-9]:[0-9][0-9].[0-9][0-9]");
                            Match b = Regex.Match(str, @"[^\d.\[\]:].{0,50}");
                            string time = a.ToString();
                            string minute = time.Split(new char[] { ':' })[0];
                            string second = time.Split(new char[] { ':', ']' })[1];
                            double parseMinute = double.Parse(minute) * 60;
                            double parseSecond = double.Parse(second);
                            totalCount = parseMinute + parseSecond;
                            lyricTimeList.Add(totalCount);
                            lyricTextList.Add(b.ToString());
                        }
                    }
                    lyricStatus = true;
                }
                else
                {
                    lyricStatus = false;
                    LyricsLbl.Text = "没有歌词";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lyricStatus;
        }

        private void NetVedioBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入视频链接！！！", "提示");
                return;
            }
            string url = textBox1.Text.Trim();
            string comUrl = comboBox1.SelectedValue.ToString();
            string reqUrl = comUrl + url;
            System.Diagnostics.Process.Start(reqUrl);
        }

        private void LocalVideoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "视频文件|*.mp4; *.mkv; *.avi; *.rmvb;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Form2 f2 = new Form2(ofd.FileName);
                f2.ShowDialog();
            }
        }
        #endregion

        #region 是否显示歌词
        public void IsShowLyricText()
        {
            if (listBox1.SelectedIndex >= 0)
            {
                double currentTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                if (currentTime >= lyricTimeList[lyricTimeList.Count - 1])
                {
                    LyricsLbl.Text = "歌词结束...";
                }
                else
                {
                    for (int i = 0; i < lyricTimeList.Count; i++)
                    {
                        if (currentTime > lyricTimeList[i] && currentTime < lyricTimeList[i + 1])
                        {
                            if (lyricTextList[i].Contains("("))
                            {
                                LyricsLbl.Text = lyricTextList[i].Substring(0, lyricTextList[i].LastIndexOf("("));
                                TranslateLbl.Text = lyricTextList[i].Substring(lyricTextList[i].LastIndexOf('(') + 1).Replace(")", "");
                            }
                        }
                        else
                        {
                            LyricsLbl.Text = lyricTextList[i];
                            TranslateLbl.Text = "无翻译...";
                        }
                    }
                }
            }
        }
        #endregion
    }
}
