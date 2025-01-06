using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class Caphe : sanpham
    {
        public int daban { get; set; }
        public double danhgia { get; set; }
        public int luotdanhgia { get; set; }

        public Caphe() : base() { }

        public Caphe(string Id, string Img, string Ten, double Giagoc, int Sale, int Soluong, int Daban, double Danhgia, int Luotdanhgia)
            : base(Id, Img, Ten, Giagoc, Sale, Soluong)
        {
            daban = Daban;
            danhgia = Danhgia;
            luotdanhgia = Luotdanhgia;
        }

        public Caphe(Caphe caphe)
            : this(caphe.id, caphe.img, caphe.ten, caphe.giagoc, caphe.sale, caphe.soluong, caphe.daban, caphe.danhgia, caphe.luotdanhgia) { }

        public override string ToString()
        {
            return $"{base.ToString()},{daban},{danhgia},{luotdanhgia}";
        }
    }

}
