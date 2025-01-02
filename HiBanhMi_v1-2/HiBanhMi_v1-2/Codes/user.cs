using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiBanhMi_v1_2.Codes
{
    internal class user
    {
        public string avata {  get; set; }
        public string taikhoan { get; set; }
        public string hoten { get; set; }
        public string sdt { get; set; }
        public string sinhnhat { get; set; }
        public string diachi { get; set; }
        public string nickname { get; set; }
        public string gioitinh {  get; set; }

        public user() { }

        public user(string avata, string taikhoan, string hoten, string sdt, string sinhnhat, string diachi, string nickname, string gioitinh)
        {
            this.avata = avata;
            this.taikhoan = taikhoan;
            this.hoten = hoten;
            this.sdt = sdt;
            this.sinhnhat = sinhnhat;
            this.diachi = diachi;
            this.nickname = nickname;
            this.gioitinh = gioitinh;
        }
        public user(user us)
        {
            this.avata = us.avata;
            this.taikhoan=us.taikhoan;
            this.hoten = us.hoten;
            this.sdt = us.sdt;
            this.sinhnhat=us.sinhnhat;
            this.diachi=us.diachi;
            this.nickname = us.nickname;
            this.gioitinh=us.gioitinh;
        }

        public override string ToString()
        {
            return $"{taikhoan},{hoten},{nickname},{sdt},{gioitinh},{diachi},{sinhnhat},{avata}";
        }
    }
}
