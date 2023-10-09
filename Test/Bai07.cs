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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Test
{
    public partial class Bai07 : Form
    {

        public Bai07()
        {
            InitializeComponent();

        }
        List<Employee> lstEmp;
        BindingSource bs = new BindingSource();


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGender.Checked)
            {
                ckGender.Text = "nam";
            }
            else
            {
                ckGender.Text = "Nữ";
            }
        }

        private void Bai07_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.25);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
        }

        private bool IsDuplicateID(string id)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == id)
                {
                    return true;
                }
            }
            return false;
        }
            private void Them_Click(object sender, EventArgs e)
        {

                if (IsDuplicateID(tbId.Text))
                {
                    MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                ListViewItem item = listView1.Items.Add(tbId.Text);
            item.SubItems.Add(tbName.Text);
            item.SubItems.Add(tbAge.Text);
            item.SubItems.Add(ckGender.Text);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]); 
            }
            else
            {
                MessageBox.Show("Phải chọn ít nhất 1 dòng");
            }
        }
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                tbId.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tbName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbAge.Text = listView1.SelectedItems[0].SubItems[2].Text;
                ckGender.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = tbId.Text;
            listView1.SelectedItems[0].SubItems[1].Text = tbName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = tbAge.Text;
            listView1.SelectedItems[0].SubItems[3].Text = ckGender.Text;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            tbId.Text = " ";
            tbName.Text = " ";
            tbAge.Text = " ";
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (!tbId.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại id");
                // Đặt focus vào ô tên
                tbId.Focus();
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            if (!tbAge.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại tuổi");
                // Đặt focus vào ô tên
                tbAge.Focus();
            }
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            btFile.SizeMode = PictureBoxSizeMode.StretchImage; 
            OpenFileDialog dlg  = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                btFile.ImageLocation = dlg.FileName;        
            }
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            tbId.Text = null;
            tbName.Text= null;
            tbAge.Text = null;
            
        }
    }
}
