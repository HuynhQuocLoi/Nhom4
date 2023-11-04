namespace Nhom4
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            FormChuongTrinh f=new FormChuongTrinh();
            this.Hide();
            f.ShowDialog();
            //this.Show();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
        if(MessageBox.Show("Bạn có muốn thoát chương trình","Thông Báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}