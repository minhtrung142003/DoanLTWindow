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
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            int year = int.Parse(tbYear.Text);
            if(year > 2000)
                e.Cancel = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYear_Click(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 1f957d5f7e24504337d51bcd3c494ea9254b8579
    }
}
