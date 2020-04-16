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
using AForge.Imaging.Formats;

namespace Midterm_108325104_糠依婷
{//邊緣偵測
    public partial class Form7 : Form
    {
        Bitmap bmp;
        Image<Gray, Byte> gimg;
        Image<Gray, float> x, y, sobel;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = ImageDecoder.DecodeFromFile(openFileDialog1.FileName);
                pictureBox1.Image = bmp;

                gimg = new Image<Gray, Byte>(bmp);
                x = gimg.Sobel(1, 0, 3);//水平
                y = gimg.Sobel(0, 1, 3);//垂直
                //label1.Text = "" + x;

                //因為sobel出來的值都是負數，所以要取絕對值
                x = x.AbsDiff(new Gray(0));
                y = y.AbsDiff(new Gray(0));

                sobel = x + y;
                sobel = 255 - sobel; //畫出來的顏色跟題目相反，所以用255減
                double[] max, min;
                Point[] minLoc, maxLoc; //找最大最小值的地方
                sobel.MinMax(out min, out max, out minLoc, out maxLoc); //MinMax會自動找最大最小
                Image<Gray, Byte> sobelimg = sobel.ConvertScale<byte>(255 / max[0], 0);

                sobelimg._ThresholdBinary(new Gray(140), new Gray(255));
                pictureBox2.Image = sobelimg.ToBitmap(sobelimg.Width, sobelimg.Height);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }

    }
}
