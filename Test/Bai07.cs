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
using System.Data.SqlClient; 
namespace Test
{
    public partial class Bai07 : Form
    {
        SqlConnection Connection;
        SqlCommand Command;
        string str = "Data Source=TIEUPHU\\TIEUPHU;Initial Catalog=QLSINHVIEN;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "select * from ThongTinSinhVien  ";
            adapter.SelectCommand = Command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table; 
        }

        public Bai07()
        {
            InitializeComponent();
           
        }
        
        private void Bai07_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(str);
            Connection.Open();
            loaddata(); 
        }

       
      
        private void Reset_Click_1(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbName.Text = "";
            tbAge.Text = "";
            cb_gioitinh.Text = "";

        }

        private bool IsDuplicateID(string id)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["MaSV"].Value != null && row.Cells["MaSV"].Value.ToString() == id)
                {
                    return true;
                }
            }
            return false;

        }
        private void Them_Click(object sender, EventArgs e)
        {
           
            Command = Connection.CreateCommand();
            Command.CommandText = "insert into ThongTinSinhVien values('"+tbId.Text+"', N'"+tbName.Text+ "', '"+tbAge.Text+ "', N'"+cb_gioitinh.Text+"')";
            if (IsDuplicateID(tbId.Text))
            {
                MessageBox.Show("ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
            Command.ExecuteNonQuery();
            loaddata();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "delete from ThongTinSinhVien where MaSV = '"+tbId.Text+"'";
            Command.ExecuteNonQuery();
            loaddata(); 
        }

        private void Out_Click_1(object sender, EventArgs e)
        {
            Close();
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
                tbId.Focus();
            }
        }   
      
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbId.ReadOnly = true;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            int i;
            i = dgv.CurrentRow.Index;
            tbId.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbName.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbAge.Text = dgv.Rows[i].Cells[2].Value.ToString();
            cb_gioitinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "update ThongTinSinhVien set TenSV = N'"+tbName.Text+"', Tuoi = "+tbAge.Text+", GioiTinh = N'"+cb_gioitinh.Text+"' where MaSV = '"+tbId.Text+"'";
            Command.ExecuteNonQuery();
            loaddata();
        }
    }
}
