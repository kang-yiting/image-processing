using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge.Imaging;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using System.Diagnostics;

namespace Midterm_108325104_糠依婷
{//旋轉
    public partial class Form9 : Form
    {
        Bitmap bmp;

        public Form9()
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
            
                RotateBicubic filter = new RotateBicubic(0, true);//初始設定0度
                Bitmap rotateimg = filter.Apply(bmp);
                pictureBox2.Image = rotateimg;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)//旋轉
        {
            label1.Text = "" + trackBar1.Value;
            double angle = Convert.ToDouble(label1.Text); //轉double
            RotateBicubic filter = new RotateBicubic(angle, true);//rotatebicubic(double,bool)

            Bitmap rotateimg = filter.Apply(bmp);
            pictureBox2.Image = rotateimg;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
