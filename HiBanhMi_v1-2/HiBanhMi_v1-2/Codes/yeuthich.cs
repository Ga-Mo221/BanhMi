using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class yeuthich
    {
        private string iduse;
        private string masp;
        private int chiso;

        public string Iduse
        {
            get => iduse; set => iduse = value;
        }
        public string Masp
        {
            get => masp; set => masp = value;
        }
        public int Chiso
        {
            get => chiso; set => chiso = value;
        }

        public yeuthich() { }
        public yeuthich(string iduse, string masp, int chiso)
        {
            this.iduse = iduse;
            this.masp = masp;
            this.chiso = chiso; 
        }

        public yeuthich(yeuthich yt)
        {
            this.iduse = yt.iduse;
            this.masp = yt.masp;
            this.chiso = yt.chiso;
        }

        public override string ToString()
        {
            return $"{this.iduse},{this.masp},{this.chiso}";
        }
    }

    internal static class listyt
    {
        public static List<yeuthich> yt = new List<yeuthich>();
    }
}
