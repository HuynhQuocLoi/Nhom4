namespace Nhom4
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tenquan = new System.Windows.Forms.Label();
            this.taikhoan = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.dangnhap = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenquan
            // 
            this.tenquan.AutoSize = true;
            this.tenquan.Font = new System.Drawing.Font("UTM Akashi", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tenquan.Location = new System.Drawing.Point(193, 65);
            this.tenquan.Name = "tenquan";
            this.tenquan.Size = new System.Drawing.Size(342, 51);
            this.tenquan.TabIndex = 0;
            this.tenquan.Text = "fiveStarCoffee";
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.Font = new System.Drawing.Font("UTM Akashi", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.taikhoan.Location = new System.Drawing.Point(118, 157);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(138, 26);
            this.taikhoan.TabIndex = 1;
            this.taikhoan.Text = "Tài Khoản";
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("UTM Akashi", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matkhau.Location = new System.Drawing.Point(125, 221);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(131, 26);
            this.matkhau.TabIndex = 1;
            this.matkhau.Text = "Mật Khẩu";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(262, 157);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(301, 26);
            this.txttaikhoan.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(262, 221);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(301, 26);
            this.txtmatkhau.TabIndex = 2;
            // 
            // dangnhap
            // 
            this.dangnhap.AutoSize = true;
            this.dangnhap.Font = new System.Drawing.Font("UTM Akashi", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dangnhap.Location = new System.Drawing.Point(193, 293);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(149, 26);
            this.dangnhap.TabIndex = 1;
            this.dangnhap.Text = "Đăng Nhập";
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // Thoat
            // 
            this.Thoat.AutoSize = true;
            this.Thoat.Font = new System.Drawing.Font("UTM Akashi", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Thoat.Location = new System.Drawing.Point(430, 293);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(84, 26);
            this.Thoat.TabIndex = 1;
            this.Thoat.Text = "Thoát";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.tenquan);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tenquan;
        private Label taikhoan;
        private Label matkhau;
        private TextBox txttaikhoan;
        private TextBox txtmatkhau;
        private Label dangnhap;
        private Label Thoat;
    }
}