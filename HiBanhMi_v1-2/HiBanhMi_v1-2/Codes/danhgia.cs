using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class danhgia
    {
        private string masp;
        private string img;
        private string user;
        private string chude;
        private string noidung;

        public string Masp { get =>  masp; set => masp = value;}
        public string Img { get => img; set => img = value;}
        public string User { get => user; set => user = value;}
        public string Chude { get => chude; set => chude = value;}
        public string Noidung { get => noidung; set => noidung = value;}


        public danhgia() { }

        public danhgia(string Masp, string Img, string User, string Chude, string Noidung)
        {
            this.masp = Masp;
            this.img = Img;
            this.user = User;
            this.chude = Chude;
            this.noidung = Noidung;
        }

        public override string ToString()
        {
            return $"{masp}|{img}|{user}|{chude}|{noidung}";
        }
    }

    internal static class listdg
    {
        public static List<danhgia> dg = new List<danhgia>();
    }
}
