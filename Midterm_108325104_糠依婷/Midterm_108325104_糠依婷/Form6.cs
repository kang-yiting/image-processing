using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Emgu.CV.Util;
using AForge.Imaging;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;

namespace Midterm_108325104_糠依婷
{//銳化
    public partial class Form6 : Form
    {
        Bitmap bmp;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bmp =ImageDecoder.DecodeFromFile(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            
                Sharpen filter = new Sharpen();
                bmp = filter.Apply(bmp);
                pictureBox3.Image = bmp;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            list f = new list();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
