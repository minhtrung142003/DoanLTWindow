using System;
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
    public partial class bai03 : Form
    {
        public bai03()
        {
            InitializeComponent();
        }
        float sodautien, tong;
        string tinhtong;
        private void button24_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "1";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "2";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "3";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tinhtong = "tru";
            sodautien = float.Parse(Show1.Text);
            Show1.Text = null;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if(tinhtong=="cong")
            {
                tong = sodautien + float.Parse(Show1.Text);
                Show1.Text = sodautien.ToString() + "" + "+" + " " + float.Parse(Show1.Text) + "=";
                Show2.Text = tong.ToString();
            }
            if (tinhtong == "tru")
            {
                tong = sodautien - float.Parse(Show1.Text);
                Show1.Text = sodautien.ToString() + "" + "-" + " " + float.Parse(Show1.Text) + "=";
                Show2.Text = tong.ToString();
            }
            if (tinhtong == "nhan")
            {
                tong = sodautien * float.Parse(Show1.Text);
                Show1.Text = sodautien.ToString() + "" + "*" + " " + float.Parse(Show1.Text) + "=";
                Show2.Text = tong.ToString();
            }
            if (tinhtong == "chia")
            {
                tong = sodautien / float.Parse(Show1.Text);
                Show1.Text = sodautien.ToString() + "" + "/" + " " + float.Parse(Show1.Text) + "=";
                Show2.Text = tong.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Show1.Text=null; Show2.Text=null;

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "7";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "8";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Show1.Text = Show1.Text + "9";

        }

        private void cong_Click(object sender, EventArgs e)
        {
            tinhtong = "cong";
            sodautien = float.Parse(Show1.Text);
            Show1.Text = null;
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            tinhtong = "nhan";
            sodautien = float.Parse(Show1.Text);
            Show1.Text = null;
        }

        private void chia_Click(object sender, EventArgs e)
        {
            tinhtong = "chia";
            sodautien = float.Parse(Show1.Text);
            Show1.Text = null;
        }

        private void Show1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
