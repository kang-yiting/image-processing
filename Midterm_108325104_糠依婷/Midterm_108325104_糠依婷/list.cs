﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//20200415
namespace Midterm_108325104_糠依婷
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        private void list_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//開啟form1
        {
            Form1 f = new Form1();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button2_Click(object sender, EventArgs e)//開啟form2
        {
            Form2 f = new Form2();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
            this.ShowInTaskbar = false;
            this.Opacity = 0;
        }
    }
}
