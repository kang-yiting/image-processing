using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV.CvEnum;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
namespace Midterm_108325104_糠依婷
{//二值化
    public partial class Form3 : Form
    {
        Image<Gray, byte> img,thresholdimg;
        Gray threshold;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void imageBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                img = new Image<Gray, byte>(filename.FileName);
                imageBox1.Image = img;
                threshold = new Gray(0);//二值化的閥值
                thresholdimg = img.ThresholdBinary(threshold, new Gray(255));//取得二值化影像
                imageBox2.Image = thresholdimg;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "" + trackBar1.Value;//顯示滾輪的值
            threshold = new Gray(trackBar1.Value);
            thresholdimg = img.ThresholdBinary(threshold, new Gray(255));
            imageBox2.Image = thresholdimg;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }
    }
}