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
    public partial class bai02 : Form
    {
        public bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(SonguyenX.Text) + int.Parse(SonguyenY.Text);
            Ketqua.Text = SonguyenX.Text + " " + "+" + " " + SonguyenY.Text + " " + "=" + " " + tong;
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(SonguyenX.Text) - int.Parse(SonguyenY.Text);
            Ketqua.Text = SonguyenX.Text + " " + "-" + " " + SonguyenY.Text + " " + "=" + " " + tong;
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(SonguyenX.Text) * int.Parse(SonguyenY.Text);
            Ketqua.Text = SonguyenX.Text + " " + "*" + " " + SonguyenY.Text + " " + "=" + " " + tong;
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            int tong = 0;
            tong = int.Parse(SonguyenX.Text) / int.Parse(SonguyenY.Text);
            Ketqua.Text = SonguyenX.Text + " " + "/" + " " + SonguyenY.Text + " " + "=" + " " + tong;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            SonguyenX.Text = null;
            SonguyenY.Text = null;
            Ketqua.Text= null;
        }

        private void bai02_Load(object sender, EventArgs e)
        {

        }
    }
}

