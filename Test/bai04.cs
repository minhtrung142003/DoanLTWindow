using System;
using System.Collections;
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
    public partial class bai04 : Form
    {
        public bai04()
        {
            InitializeComponent();
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id ;
        }

        private void bai04_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }


        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();
            Faculty f = new Faculty();
            f.id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f  = new Faculty();
            f.id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.id = "K03";
            f.Name = "Kế toán";
            f.Quantity = 5200;
            lst.Add(f);

            f = new Faculty();
            f.id = "K04";
            f.Name = "Điện";
            f.Quantity = 6200;
            lst.Add(f);

            f = new Faculty();
            f.id = "K05";
            f.Name = "Cơ khí";
            f.Quantity = 5780;
            lst.Add(f);
            return lst;

        }
    }
}
