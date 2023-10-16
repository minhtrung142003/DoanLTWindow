using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using static Test.themmoi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class Bai07 : Form
    {
        private List<themmoi.Employee> lstEmp;
        private BindingSource bs;

        public Bai07()
        {
            InitializeComponent();
            lstEmp = new List<themmoi.Employee>();
            bs = new BindingSource();

        }
        
        private void Bai07_Load(object sender, EventArgs e)
        {
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
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
        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (row.Cells["Id"].Value != null && row.Cells["Id"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;

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
        private void Reset_Click_1(object sender, EventArgs e)
        {
            tbId.Text = null;
            tbName.Text = null;
            tbAge.Text = null;
            ckGender.Checked = false;

        }

        /* if (pbImage.Image != null)
            {
                dgvEmployee.Rows.Add(tbId.Text, tbName.Text, ckGender.Checked, pbImage.Image);
            }
            else
            {
                // Handle the case where the PictureBox doesn't have an image.
                MessageBox.Show("Please select a valid image first.");
            }
           */
        private void Them_Click(object sender, EventArgs e)
        {
           
            if (IsDuplicateID(tbId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            if (pbImage.Image != null)
            {
                themmoi.Employee em = new themmoi.Employee
                {
                    Id = tbId.Text,
                    Name = tbName.Text,
                    Age = int.Parse(tbAge.Text),
                    Gender = ckGender.Checked,
                    Image = pbImage.Image,

                };

                lstEmp.Add(em);
                bs.ResetBindings(false);
            }
            else
            {
                // Handle the case where the PictureBox doesn't have an image.
                MessageBox.Show("Please select a valid image first.");
                return;
            }
            
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvEmployee.SelectedRows[0].Index;
                lstEmp.RemoveAt(selectedIndex);
                bs.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Chọn một nhân viên để xóa.");
            }
        }
        private void dgvEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells["Id"].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells["Name"].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells["Age"].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells["Gender"].Value.ToString());

            pbImage.Image = (Image)dgvEmployee.Rows[idx].Cells["Image"].Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg) |*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
                if (dgvEmployee.SelectedRows.Count > 0 )
            {
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];
                
                //selectedRow.Cells["Id"].Value = tbId.Text;
                selectedRow.Cells["Name"].Value = tbName.Text;
                selectedRow.Cells["Age"].Value = tbAge.Text;
                selectedRow.Cells["Gender"].Value = ckGender.Checked;
                selectedRow.Cells["Image"].Value = pbImage.Image;

                // Optionally, if you want to refresh the DataGridView
                dgvEmployee.Refresh();
            }
        }
        

        private void Out_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged_1(object sender, EventArgs e)
        {
            if (!tbId.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại id");
                // Đặt focus vào ô tên
                tbId.Focus();
            }
        }

        private void tbAge_TextChanged_1(object sender, EventArgs e)
        {
            if (!tbAge.Text.All(Char.IsDigit))
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Vui lòng nhập lại tuổi");
                // Đặt focus vào ô tên
                tbAge.Focus();
            }
        }   

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvEmployee.Rows[idx].Cells["Id"].Value.ToString();
            tbName.Text = dgvEmployee.Rows[idx].Cells["Name"].Value.ToString();
            tbAge.Text = dgvEmployee.Rows[idx].Cells["Age"].Value.ToString();
            ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells["Gender"].Value.ToString());

            pbImage.Image = (Image)dgvEmployee.Rows[idx].Cells["Image"].Value;
        }
    }
}
