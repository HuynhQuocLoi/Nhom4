namespace Nhom4
{
    partial class FormChuongTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminCT = new System.Windows.Forms.ToolStripMenuItem();
            this.tttkCT = new System.Windows.Forms.ToolStripMenuItem();
            this.ttctCT = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatCT = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.soluongthem = new System.Windows.Forms.NumericUpDown();
            this.thanhtoan = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.mon = new System.Windows.Forms.ComboBox();
            this.danhmuc = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongthem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminCT,
            this.tttkCT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminCT
            // 
            this.adminCT.Name = "adminCT";
            this.adminCT.Size = new System.Drawing.Size(65, 24);
            this.adminCT.Text = "admin";
            this.adminCT.Click += new System.EventHandler(this.adminCT_Click);
            // 
            // tttkCT
            // 
            this.tttkCT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttctCT,
            this.dangxuatCT});
            this.tttkCT.Name = "tttkCT";
            this.tttkCT.Size = new System.Drawing.Size(151, 24);
            this.tttkCT.Text = "Thông tin tài khoản";
            // 
            // ttctCT
            // 
            this.ttctCT.Name = "ttctCT";
            this.ttctCT.Size = new System.Drawing.Size(209, 26);
            this.ttctCT.Text = "Thông tin cá nhân";
            this.ttctCT.Click += new System.EventHandler(this.ttctCT_Click);
            // 
            // dangxuatCT
            // 
            this.dangxuatCT.Name = "dangxuatCT";
            this.dangxuatCT.Size = new System.Drawing.Size(209, 26);
            this.dangxuatCT.Text = "Đăng Xuất";
            this.dangxuatCT.Click += new System.EventHandler(this.dangxuatCT_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 531);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(643, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 532);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(407, 524);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.soluongthem);
            this.panel4.Controls.Add(this.thanhtoan);
            this.panel4.Controls.Add(this.Them);
            this.panel4.Controls.Add(this.mon);
            this.panel4.Controls.Add(this.danhmuc);
            this.panel4.Location = new System.Drawing.Point(1077, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 288);
            this.panel4.TabIndex = 4;
            // 
            // soluongthem
            // 
            this.soluongthem.Location = new System.Drawing.Point(133, 88);
            this.soluongthem.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.soluongthem.Name = "soluongthem";
            this.soluongthem.Size = new System.Drawing.Size(77, 26);
            this.soluongthem.TabIndex = 2;
            // 
            // thanhtoan
            // 
            this.thanhtoan.Location = new System.Drawing.Point(8, 125);
            this.thanhtoan.Name = "thanhtoan";
            this.thanhtoan.Size = new System.Drawing.Size(106, 39);
            this.thanhtoan.TabIndex = 1;
            this.thanhtoan.Text = "Thanh Toán";
            this.thanhtoan.UseVisualStyleBackColor = true;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(8, 80);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(106, 39);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            // 
            // mon
            // 
            this.mon.FormattingEnabled = true;
            this.mon.Location = new System.Drawing.Point(8, 47);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(229, 27);
            this.mon.TabIndex = 0;
            // 
            // danhmuc
            // 
            this.danhmuc.FormattingEnabled = true;
            this.danhmuc.Location = new System.Drawing.Point(8, 14);
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(229, 27);
            this.danhmuc.TabIndex = 0;
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 599);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuongTrinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soluongthem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tttkCT;
        private ToolStripMenuItem ttctCT;
        private ToolStripMenuItem dangxuatCT;
        private Panel panel1;
        private Panel panel2;
        private ListView listView1;
        private Panel panel4;
        private NumericUpDown soluongthem;
        private Button Them;
        private ComboBox mon;
        private ComboBox danhmuc;
        private Button thanhtoan;
        private ToolStripMenuItem adminCT;
    }
}