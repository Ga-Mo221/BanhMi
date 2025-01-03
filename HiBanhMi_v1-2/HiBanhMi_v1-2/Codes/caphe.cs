using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class Caphe : sanpham
    {
        public string loaiCaPhe { get; set; } // Ví dụ: "Đen", "Sữa", "Espresso"
        public string kichThuoc { get; set; } // Ví dụ: "Nhỏ", "Vừa", "Lớn"
        public int duong { get; set; } // Mức độ đường (gói)

        public Caphe() : base() { }

        public Caphe(string Id, string Img, string Ten, double Giagoc, int Sale, int Soluong, string LoaiCaPhe, string KichThuoc, int Duong)
            : base(Id, Img, Ten, Giagoc, Sale, Soluong)
        {
            loaiCaPhe = LoaiCaPhe;
            kichThuoc = KichThuoc;
            duong = Duong;
        }

        public Caphe(Caphe caphe)
            : this(caphe.id, caphe.img, caphe.ten, caphe.giagoc, caphe.sale, caphe.soluong, caphe.loaiCaPhe, caphe.kichThuoc, caphe.duong) { }

        public override string ToString()
        {
            return $"{base.ToString()},{loaiCaPhe},{kichThuoc},{duong}";
        }
    }

}
