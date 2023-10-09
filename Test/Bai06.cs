using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }
        float sodautien, tong;
        string tinhtong;

        private void button8_Click(object sender, EventArgs e)
        {
            if (tinhtong == "cong")
            {
                tong = sodautien + float.Parse(show1.Text);
                show1.Text = sodautien.ToString() + "" + "+" + " " + float.Parse(show1.Text) + "=";
                show2.Text = tong.ToString();
            }

            if (tinhtong == "nhan")
            {
                tong = sodautien * float.Parse(show1.Text);
                show1.Text = sodautien.ToString() + "" + "*" + " " + float.Parse(show1.Text) + "=";
                show2.Text = tong.ToString();
            }
        }
     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show1.Text = show1.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show1.Text= show1.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show1.Text = show1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show1.Text = show1.Text + "3"; 
        }

        private void cong_Click(object sender, EventArgs e)
        {
            tinhtong = "cong";
            sodautien = float.Parse(show1.Text);
            show1.Text = null;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            tinhtong = "nhan";
            sodautien = float.Parse(show1.Text);
            show1.Text = null;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            show1.Text = " ";
            show2.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
