namespace PhanQuyenApp
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.txbLoaiTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQLDatPhong = new System.Windows.Forms.CheckBox();
            this.cbThongTinChung = new System.Windows.Forms.CheckBox();
            this.cbThuChi = new System.Windows.Forms.CheckBox();
            this.cbQLKho = new System.Windows.Forms.CheckBox();
            this.cbQLBanHang = new System.Windows.Forms.CheckBox();
            this.cbBuongPhong = new System.Windows.Forms.CheckBox();
            this.cbEmaiMarketing = new System.Windows.Forms.CheckBox();
            this.cbThongKe = new System.Windows.Forms.CheckBox();
            this.cbBaoCao = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightGreen;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(531, 12);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(104, 34);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Plum;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(160, 34);
            this.btnQuanLyTaiKhoan.TabIndex = 5;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // txbLoaiTK
            // 
            this.txbLoaiTK.Enabled = false;
            this.txbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoaiTK.Location = new System.Drawing.Point(324, 16);
            this.txbLoaiTK.Name = "txbLoaiTK";
            this.txbLoaiTK.Size = new System.Drawing.Size(170, 26);
            this.txbLoaiTK.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loại tài khoản :";
            // 
            // cbQLDatPhong
            // 
            this.cbQLDatPhong.AutoSize = true;
            this.cbQLDatPhong.Checked = true;
            this.cbQLDatPhong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQLDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQLDatPhong.Location = new System.Drawing.Point(31, 65);
            this.cbQLDatPhong.Name = "cbQLDatPhong";
            this.cbQLDatPhong.Size = new System.Drawing.Size(157, 24);
            this.cbQLDatPhong.TabIndex = 12;
            this.cbQLDatPhong.Text = "Quản lý đặt phòng";
            this.cbQLDatPhong.UseVisualStyleBackColor = true;
            // 
            // cbThongTinChung
            // 
            this.cbThongTinChung.AutoSize = true;
            this.cbThongTinChung.Checked = true;
            this.cbThongTinChung.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbThongTinChung.Location = new System.Drawing.Point(31, 95);
            this.cbThongTinChung.Name = "cbThongTinChung";
            this.cbThongTinChung.Size = new System.Drawing.Size(149, 24);
            this.cbThongTinChung.TabIndex = 13;
            this.cbThongTinChung.Text = "Thông Tin Chung";
            this.cbThongTinChung.UseVisualStyleBackColor = true;
            // 
            // cbThuChi
            // 
            this.cbThuChi.AutoSize = true;
            this.cbThuChi.Checked = true;
            this.cbThuChi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbThuChi.Location = new System.Drawing.Point(31, 125);
            this.cbThuChi.Name = "cbThuChi";
            this.cbThuChi.Size = new System.Drawing.Size(82, 24);
            this.cbThuChi.TabIndex = 14;
            this.cbThuChi.Text = "Thu Chi";
            this.cbThuChi.UseVisualStyleBackColor = true;
            // 
            // cbQLKho
            // 
            this.cbQLKho.AutoSize = true;
            this.cbQLKho.Checked = true;
            this.cbQLKho.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQLKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQLKho.Location = new System.Drawing.Point(391, 65);
            this.cbQLKho.Name = "cbQLKho";
            this.cbQLKho.Size = new System.Drawing.Size(111, 24);
            this.cbQLKho.TabIndex = 15;
            this.cbQLKho.Text = "Quản lý kho";
            this.cbQLKho.UseVisualStyleBackColor = true;
            // 
            // cbQLBanHang
            // 
            this.cbQLBanHang.AutoSize = true;
            this.cbQLBanHang.Checked = true;
            this.cbQLBanHang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQLBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbQLBanHang.Location = new System.Drawing.Point(219, 65);
            this.cbQLBanHang.Name = "cbQLBanHang";
            this.cbQLBanHang.Size = new System.Drawing.Size(152, 24);
            this.cbQLBanHang.TabIndex = 16;
            this.cbQLBanHang.Text = "Quản lý bán hàng";
            this.cbQLBanHang.UseVisualStyleBackColor = true;
            // 
            // cbBuongPhong
            // 
            this.cbBuongPhong.AutoSize = true;
            this.cbBuongPhong.Checked = true;
            this.cbBuongPhong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBuongPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbBuongPhong.Location = new System.Drawing.Point(219, 95);
            this.cbBuongPhong.Name = "cbBuongPhong";
            this.cbBuongPhong.Size = new System.Drawing.Size(124, 24);
            this.cbBuongPhong.TabIndex = 17;
            this.cbBuongPhong.Text = "Buồng phòng";
            this.cbBuongPhong.UseVisualStyleBackColor = true;
            // 
            // cbEmaiMarketing
            // 
            this.cbEmaiMarketing.AutoSize = true;
            this.cbEmaiMarketing.Checked = true;
            this.cbEmaiMarketing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEmaiMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbEmaiMarketing.Location = new System.Drawing.Point(219, 125);
            this.cbEmaiMarketing.Name = "cbEmaiMarketing";
            this.cbEmaiMarketing.Size = new System.Drawing.Size(141, 24);
            this.cbEmaiMarketing.TabIndex = 18;
            this.cbEmaiMarketing.Text = "Email marketing";
            this.cbEmaiMarketing.UseVisualStyleBackColor = true;
            // 
            // cbThongKe
            // 
            this.cbThongKe.AutoSize = true;
            this.cbThongKe.Checked = true;
            this.cbThongKe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbThongKe.Location = new System.Drawing.Point(391, 95);
            this.cbThongKe.Name = "cbThongKe";
            this.cbThongKe.Size = new System.Drawing.Size(94, 24);
            this.cbThongKe.TabIndex = 19;
            this.cbThongKe.Text = "Thống kê";
            this.cbThongKe.UseVisualStyleBackColor = true;
            // 
            // cbBaoCao
            // 
            this.cbBaoCao.AutoSize = true;
            this.cbBaoCao.Checked = true;
            this.cbBaoCao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbBaoCao.Location = new System.Drawing.Point(391, 125);
            this.cbBaoCao.Name = "cbBaoCao";
            this.cbBaoCao.Size = new System.Drawing.Size(87, 24);
            this.cbBaoCao.TabIndex = 20;
            this.cbBaoCao.Text = "Báo cáo";
            this.cbBaoCao.UseVisualStyleBackColor = true;
            // 
            // FormChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 293);
            this.Controls.Add(this.cbBaoCao);
            this.Controls.Add(this.cbThongKe);
            this.Controls.Add(this.cbEmaiMarketing);
            this.Controls.Add(this.cbBuongPhong);
            this.Controls.Add(this.cbQLBanHang);
            this.Controls.Add(this.cbQLKho);
            this.Controls.Add(this.cbThuChi);
            this.Controls.Add(this.cbThongTinChung);
            this.Controls.Add(this.cbQLDatPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLoaiTK);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Controls.Add(this.btnDangXuat);
            this.Name = "FormChuongTrinh";
            this.Text = "Trang Chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChuongTrinh_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChuongTrinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChuongTrinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.TextBox txbLoaiTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbQLDatPhong;
        private System.Windows.Forms.CheckBox cbThongTinChung;
        private System.Windows.Forms.CheckBox cbThuChi;
        private System.Windows.Forms.CheckBox cbQLKho;
        private System.Windows.Forms.CheckBox cbQLBanHang;
        private System.Windows.Forms.CheckBox cbBuongPhong;
        private System.Windows.Forms.CheckBox cbEmaiMarketing;
        private System.Windows.Forms.CheckBox cbThongKe;
        private System.Windows.Forms.CheckBox cbBaoCao;
    }
}