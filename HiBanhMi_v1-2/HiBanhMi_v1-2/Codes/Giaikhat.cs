using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class Giaikhat : sanpham
    {
        public string loaiDoUong { get; set; } // Ví dụ: "Nước ngọt", "Trà", "Nước suối"
        public int dungTich { get; set; } // Đơn vị: ml
        public string huongVi { get; set; } // Ví dụ: "Chanh", "Cam", "Dâu"

        public Giaikhat() : base() { }

        public Giaikhat(string Id, string Img, string Ten, double Giagoc, int Sale, int Soluong, string LoaiDoUong, int DungTich, string HuongVi)
            : base(Id, Img, Ten, Giagoc, Sale, Soluong)
        {
            loaiDoUong = LoaiDoUong;
            dungTich = DungTich;
            huongVi = HuongVi;
        }

        public Giaikhat(Giaikhat giaikhat)
            : this(giaikhat.id, giaikhat.img, giaikhat.ten, giaikhat.giagoc, giaikhat.sale, giaikhat.soluong, giaikhat.loaiDoUong, giaikhat.dungTich, giaikhat.huongVi) { }

        public override string ToString()
        {
            return $"{base.ToString()},{loaiDoUong},{dungTich},{huongVi}";
        }
    }

}
