using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class Giaikhat : sanpham
    {
        public int daban { get; set; }
        public double danhgia { get; set; }
        public int luotdanhgia { get; set; }

        public Giaikhat() : base() { }

        public Giaikhat(string Id, string Img, string Ten, double Giagoc, int Sale, int Soluong, int Daban, double Danhgia, int Luotdanhgia)
            : base(Id, Img, Ten, Giagoc, Sale, Soluong)
        {
            daban = Daban;
            danhgia = Danhgia;
            luotdanhgia = Luotdanhgia;
        }

        public Giaikhat(Giaikhat giaikhat)
            : this(giaikhat.id, giaikhat.img, giaikhat.ten, giaikhat.giagoc, giaikhat.sale, giaikhat.soluong, giaikhat.daban, giaikhat.danhgia, giaikhat.luotdanhgia) { }

        public override string ToString()
        {
            return $"{base.ToString()},{daban},{danhgia},{luotdanhgia}";
        }
    }

}
