﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new bai04().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new bai02().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new bai03().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Bai05().ShowDialog();
        }

        private void Bai06_Click(object sender, EventArgs e)
        {
            new Bai06().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Bai07().ShowDialog();
        }
    }
}
