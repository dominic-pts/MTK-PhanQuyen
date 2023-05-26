using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyenApp
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Instance { get
            {
                if (instance == null)
                {
                    instance = new DanhSachTaiKhoan();
                }
                return instance;
            }
            set => instance = value; }

        List<TaiKhoan> listTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("admin", "12345678",TaiKhoan.LoaiTK.chuks));
            listTaiKhoan.Add(new TaiKhoan("son", "12345678",TaiKhoan.LoaiTK.quanly));
            listTaiKhoan.Add(new TaiKhoan("ly", "12345678", TaiKhoan.LoaiTK.letan));
            listTaiKhoan.Add(new TaiKhoan("huyen", "12345678", TaiKhoan.LoaiTK.buongphong));
        }
    }
}
