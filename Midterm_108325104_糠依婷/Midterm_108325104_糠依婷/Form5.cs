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
namespace Midterm_108325104_糠依婷
{//去雜訊
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(filename.FileName);
                imageBox1.Image = img;
                imageBox2.Image = img.SmoothMedian(5);
                //imageBox2.Image = img.SmoothGaussian(9);
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
