using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom4
{
    public partial class FormChuongTrinh : Form
    {
        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void dangxuatCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ttctCT_Click(object sender, EventArgs e)
        {
            FormTaiKhoan f =new FormTaiKhoan();
            f.ShowDialog();
        }

        private void adminCT_Click(object sender, EventArgs e)
        {
            FormAdmin f =new FormAdmin();   
            f.ShowDialog(); 
        }
    }
}
