namespace BT_Buoi3
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.libSanPham = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbThanhToan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(183, 78);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(260, 22);
            this.txtKhachHang.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(183, 112);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 22);
            this.txtSDT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thông tin đơn hàng";
            // 
            // libSanPham
            // 
            this.libSanPham.FormattingEnabled = true;
            this.libSanPham.ItemHeight = 16;
            this.libSanPham.Items.AddRange(new object[] {
            "Doraemon",
            "Kính Vạn Hoa",
            "Harry Potter"});
            this.libSanPham.Location = new System.Drawing.Point(48, 205);
            this.libSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.libSanPham.Name = "libSanPham";
            this.libSanPham.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.libSanPham.Size = new System.Drawing.Size(249, 212);
            this.libSanPham.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Danh sách sản phẩm";
            // 
            // txtThongTin
            // 
            this.txtThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.txtThongTin.Location = new System.Drawing.Point(615, 116);
            this.txtThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongTin.Multiline = true;
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.ReadOnly = true;
            this.txtThongTin.Size = new System.Drawing.Size(345, 301);
            this.txtThongTin.TabIndex = 9;
            this.txtThongTin.Text = "Thông tin đặt hàng";
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(48, 513);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(100, 28);
            this.btnDatHang.TabIndex = 10;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 432);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thanh toán";
            // 
            // cmbThanhToan
            // 
            this.cmbThanhToan.FormattingEnabled = true;
            this.cmbThanhToan.Items.AddRange(new object[] {
            "ATM",
            "Tiền mặt",
            "Thẻ tín dụng"});
            this.cmbThanhToan.Location = new System.Drawing.Point(48, 464);
            this.cmbThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbThanhToan.Name = "cmbThanhToan";
            this.cmbThanhToan.Size = new System.Drawing.Size(249, 24);
            this.cmbThanhToan.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cmbThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.libSanPham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "c";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox libSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbThanhToan;
    }
}