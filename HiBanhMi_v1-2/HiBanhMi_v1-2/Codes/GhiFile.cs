using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class GhiFile
    {
        // Ghi file taikhoan
        public void Taikhoan(List<TaiKhoan> taikhoan)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taikhoan");
            string filePath = Path.Combine(folderPath, "taikhoan.txt");


            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TaiKhoan taik in taikhoan)
                {
                    writer.WriteLine(taik.ToString(), Encoding.UTF8);
                }
            }
        }
        public void Usersetting(List<string> us)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting");
            string filePath = Path.Combine(folderPath, "usersetting.txt");
            string str ;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                str = $"{us[0]},{us[1]}";
                writer.WriteLine(str, Encoding.UTF8);
            }
        }


        public void userprofile(List<user> users)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users");
            string filePath = Path.Combine(folderPath, "users.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (user us in users)
                {
                    writer.WriteLine(us.ToString(), Encoding.UTF8);
                }
                
            }
        }
    }
}
