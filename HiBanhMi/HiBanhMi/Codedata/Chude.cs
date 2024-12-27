using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi
{
    internal class Chude
    {
        public string banhmivang(string chucnang)
        {
            string mau = null;

            StringDictionary listmau = new StringDictionary()
            {
                { "nen", "255,255,255"},
                { "nutxacnhan","237,143,7" }
            };

            mau = listmau[chucnang];
            return mau;
        }

        public int M(string mau, int vitri)
        {
            string[] rgb = mau.Split(',');
            int vt = 0;
            switch (vitri)
            {
                case 0:
                    vt = int.Parse(rgb[0]);
                    break;
                case 1:
                    vt = int.Parse(rgb[1]);
                    break;
                case 2:
                    vt = int.Parse(rgb[2]);
                    break;
            }
            return vt;
        }
    }
}
