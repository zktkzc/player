using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 播放器
{
    public partial class Form2 : Form
    {
        public Form2(string videoUrl)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = videoUrl;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
