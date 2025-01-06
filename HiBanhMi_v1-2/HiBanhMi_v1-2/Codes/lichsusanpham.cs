using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class lichsusanpham
    {
        private string madon;
        private string iduser;
        private string masp;
        private string img;
        private string ten;
        private string giagoc;
        private string giacuoi;
        private string soluong;


        public string Madon { get => madon; set => madon = value; }
        public string Iduser { get => iduser; set => iduser = value; }
        public string Ma { get => masp; set => masp = value; }
        public string Img { get => img; set => img = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Giagoc { get => giagoc; set => giagoc = value; }
        public string Giacuoi { get => giacuoi; set => giacuoi = value; }
        public string Soluong { get => soluong; set => soluong = value; }


        public lichsusanpham() { }

        public lichsusanpham(string Madon, string Iduser, string Masp, string Img, string Ten, string Soluong, string Giagoc, string Giacuoi)
        {
            this.madon = Madon;
            this.iduser = Iduser;
            this.masp = Masp;
            this.img = Img;
            this.ten = Ten;
            this.giagoc = Giagoc;
            this.giacuoi = Giacuoi;
            this.soluong = Soluong;
        }

        public override string ToString()
        {
            return $"{madon},{iduser},{masp},{img},{ten},{soluong},{giagoc},{giacuoi}";
        }

    }
    internal static class listct
    {
        public static List<lichsusanpham> lssp = new List<lichsusanpham>();
    }
}
