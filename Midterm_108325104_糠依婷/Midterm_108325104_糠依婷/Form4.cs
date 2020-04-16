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
{//侵蝕、擴張
    public partial class Form4 : Form
    {
        Image<Gray, byte> img1, img2, erodeimg, dilateimg;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            if (filename.ShowDialog() == DialogResult.OK)
            {
                img1 = new Image<Gray, byte>(filename.FileName);
                imageBox1.Image = img1;
                img2 = new Image<Gray, byte>(filename.FileName);
                imageBox1.Image = img2;

                //侵蝕
                erodeimg = img1.Erode(7);
                imageBox2.Image = erodeimg;

                //膨脹
                dilateimg = img2.Dilate(7);
                imageBox3.Image = dilateimg;
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
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
