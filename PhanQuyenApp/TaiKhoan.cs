using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyenApp
{
    public class TaiKhoan
    {
        private string tenTaiKhoan;
        //ctrl + r + e
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }

        private string matKhau;
        public string MatKhau { get => matKhau; set => matKhau = value; }

        private LoaiTK loaiTaiKhoan;
        public LoaiTK LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        //enum  kiểu liệt kê
        public enum LoaiTK
        {
            chuks,
            letan,
            quanly,
            buongphong
        }
        //đóng gói
        private string tenHienThi;
        public string TenHienThi { 
            get
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.chuks:
                        TenHienThi = "Chủ khách sạn";
                        break;
                    case LoaiTK.letan:
                        TenHienThi = "Lễ Tân";
                        break;
                    case LoaiTK.quanly:
                        TenHienThi = "Quản Lý";
                        break;
                    case LoaiTK.buongphong:
                        TenHienThi = "Buồng phòng";
                        break;
                }
                return tenHienThi;
            }
            set => tenHienThi = value; 
        }

        public TaiKhoan(string tenTaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.tenTaiKhoan = tenTaikhoan;
            this.matKhau = matkhau;
            this.loaiTaiKhoan = loaitaikhoan;
        }
    }
}
