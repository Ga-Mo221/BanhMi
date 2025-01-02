using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal static class uson
    {
        public static user users = new user();
    }
    internal static class userlist
    {
        public static List<user> users = new List<user>();
    }
    internal class upuson
    {
        public void up(string id)
        {
            bool foud = false;

            foreach (user us in userlist.users)
            {
                if (us.taikhoan == id)
                {
                    uson.users = new user(us);
                    foud = true;
                    return;
                }
            }
            if (!foud )
            {
                uson.users = new user("newacc.png", id, "null", "null", "null", "null", "null", "null");
                userlist.users.Add(uson.users);
                GhiFile ghi = new GhiFile();
                ghi.userprofile(userlist.users);
            }
        }

        public void edit(string id, string hoten, string nickname, string sdt, string gioitinh, string diachi, string sinhnhat, string avata)
        {
            foreach (user us in userlist.users)
            {
                if (us.taikhoan == id)
                {
                    uson.users = new user(avata, id, hoten, sdt, sinhnhat, diachi, nickname, gioitinh);
                    us.taikhoan = id;
                    us.hoten = hoten;
                    us.nickname = nickname;
                    us.sdt = sdt;   
                    us.gioitinh = gioitinh;
                    us.diachi = diachi; 
                    us.diachi = diachi;
                    us.sinhnhat = sinhnhat;
                    us.avata = avata;
                }
            }
        }
    }
}
