using System.Collections.Generic;


namespace HiBanhMi_v1_2.Codes
{
    internal class lichsudonhang
    {
        private string madon;
        private string iduser;
        private string thoigian;
        private string tien;
        
        public string Ma
        {
            get => madon; set => madon = value;
        }
        public string Iduser
        {
            get => iduser; set => iduser = value;
        }
        public string Tg
        {
            get => thoigian; set => thoigian = value;
        }
        public string Tien
        {
            get => tien; set => tien = value;
        }


        public lichsudonhang(string Madon, string Iduser, string Thoigian, string Tien)
        {
            this.madon = Madon;
            this.iduser = Iduser;
            this.thoigian = Thoigian;
            this.tien = Tien;
        }

        public lichsudonhang() { }

        public override string ToString()
        {
            return $"{madon},{iduser},{thoigian},{tien}";// thoigian yyyymmddhhmmss
        }
    }

    internal static class listdh
    {
        public static List<lichsudonhang> dh = new List<lichsudonhang>();
    }
}
