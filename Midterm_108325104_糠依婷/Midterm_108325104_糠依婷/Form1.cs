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
using Emgu.CV.Structure;
namespace Midterm_108325104_糠依婷
{//灰階轉換
    public partial class Form1 : Form
    {
        Image<Bgr, byte> rgbimg;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//開啟檔案
        {
            OpenFileDialog filename = new OpenFileDialog();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                rgbimg = new Image<Bgr, byte>(filename.FileName);
                imageBox1.Image = rgbimg;
            
                Image<Gray, byte> gimg = new Image<Gray, byte>(rgbimg.Bitmap);
                imageBox2.Image = gimg;
            }
        }

        private void button2_Click(object sender, EventArgs e)//開啟list 關閉form1
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }

        /*轉灰階方法二(套用AForge.NET)
        using AForge.Imaging.Formats;
        using AForge.Imaging.Filters;
        using AForge.Imaging;

            openFileDialog1.Filter = "所有檔案(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = ImageDecoder.DecodeFromFile(openFileDialog1.FileName);
                pictureBox1.Image = img1;
            }
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            img2 = filter.Apply(img1);
            pictureBox2.Image = img2;
        */  
    }
}
