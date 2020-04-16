using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace Midterm_108325104_糠依婷
{//通道轉換
    public partial class Form2 : Form
    {
        Bitmap bmp,bmp2;
        ExtractChannel filter;

        public Form2()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp = ImageDecoder.DecodeFromFile(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)//取得R通道影像
        {
            filter = new ExtractChannel(RGB.R);
            bmp2 = filter.Apply(bmp);
            pictureBox2.Image = bmp2;
        }

        private void button3_Click(object sender, EventArgs e)//G
        {
            filter = new ExtractChannel(RGB.G);
            bmp2 = filter.Apply(bmp);
            pictureBox2.Image = bmp2;
        }

        private void button4_Click(object sender, EventArgs e)//B
        {
            filter = new ExtractChannel(RGB.B);
            bmp2 = filter.Apply(bmp);
            pictureBox2.Image = bmp2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }

        /*
        要取得rgb通道，應該要先將圖片上每個pixel的rgb都記錄下來，最後再用記下來的畫圖
        using Emgu.CV;
        using Emgu.CV.Structure;
        using Emgu.CV.CvEnum;
        using System.Runtime.InteropServices;
        using System.Diagnostics;
        using Emgu.CV.Util;
            //讀取彩色影像
            Image<Bgr, byte> colorImage = new Image<Bgr, byte>(textBox1.Text);
            imageBox1.Image = colorImage;
            
            MCvMat mImg = (MCvMat)Marshal.PtrToStructure(colorImage.Ptr, typeof(MCvMat));
            byte* ptr = (byte*)mImg.Data.ToPointer();/////////////
            byte Red, Green, Blue;
            int i = 0, j = 0;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Blue = ptr[0];
                    ptr++;
                    Green = ptr[0];
                    ptr++;
                    Red = ptr[0];
                    dgv[j, i].Value = string.Format("({0},{1} = ({2},{3},{4})", i + 1, j + 1, Red, Green, Blue);
                    ptr++;
                }
            }
          */
    }
}
