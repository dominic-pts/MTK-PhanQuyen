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
    public partial class FormDangNhap : Form
    {

        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {
                FormChuongTrinh f = new FormChuongTrinh();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }else{
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txbTaiKhoan.Focus();
            }
            

        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as FormChuongTrinh).isThoat = false;
            (sender as FormChuongTrinh).Close();
            this.Show();
        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0;i < listTaiKhoan.Count; i++)
            {
                if(tentaikhoan == listTaiKhoan[i].TenTaiKhoan && matkhau == listTaiKhoan[i].MatKhau)
                {
                    Const.TaiKhoan = listTaiKhoan[i];
                    return true;
                }
            }
        
            return false;
        }
         

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuyenMatKhau quyenMatKhau = new FormQuyenMatKhau();
            quyenMatKhau.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.ShowDialog();
        }
    }
}
