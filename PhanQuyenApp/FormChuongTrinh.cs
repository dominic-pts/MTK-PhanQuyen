using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanQuyenApp
{
    public partial class FormChuongTrinh : Form
    {
        public bool isThoat = true;
        public FormChuongTrinh()
        {
            InitializeComponent();
        }
        public event EventHandler DangXuat;
        public void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat(this,new EventArgs());
            

        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isThoat)
                Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void FormChuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn Muốn Thoát Chương Trinh", "Cảnh Báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.quanly:
                    btnQuanLyTaiKhoan.Enabled = false;
                    cbBaoCao.Checked = cbThongKe.Checked = false ;
                    cbBaoCao.Enabled = cbThongKe.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.letan:
                
                    btnQuanLyTaiKhoan.Enabled = false;
                    cbThuChi.Checked = cbThongKe.Checked = cbThongTinChung.Checked = false ;
                    cbThuChi.Enabled = cbThongKe.Enabled = cbThongTinChung.Enabled = false;


                    break;
                case TaiKhoan.LoaiTK.buongphong:
                    btnQuanLyTaiKhoan.Enabled = false;
                    cbBaoCao.Checked = cbEmaiMarketing.Checked = cbQLBanHang.Checked = cbQLDatPhong.Checked = cbQLDatPhong.Checked = cbQLKho.Checked = cbThongKe.Checked = cbThongTinChung.Checked = cbThuChi.Checked = false;
                    cbBaoCao.Enabled = cbEmaiMarketing.Enabled = cbQLBanHang.Enabled = cbQLDatPhong.Enabled = cbQLDatPhong.Enabled = cbQLKho.Enabled = cbThongKe.Enabled = cbThongTinChung.Enabled = cbThuChi.Enabled = false;
                    break;

            }
            txbLoaiTK.Text = Const.TaiKhoan.TenHienThi;
        }


         private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FormQLTaiKhoan formQLTaiKhoan = new FormQLTaiKhoan();
            formQLTaiKhoan.ShowDialog();
        }
    }
}
