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

namespace Midterm_108325104_糠依婷
{//直方圖等化
    public partial class Form8 : Form
    {
        Bitmap bmp;

        public Form8()
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
            
                HistogramEqualization filter = new HistogramEqualization();
                bmp = filter.Apply(bmp);
                pictureBox2.Image = bmp;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

