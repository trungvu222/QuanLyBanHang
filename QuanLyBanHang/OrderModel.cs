using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public class OrderModel
    {
        public string MaHDBan { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKhach { get; set; }
        public double TongTien { get; set; }

        public int IdCTHD { get; set; }
        public string MaHang { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double GiamGia { get; set; }
        public double ThanhTien { get; set; }
    }
}
