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


        public void YeuThich(List<yeuthich> yt)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "spyeuthich.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (yeuthich yeut in yt)
                {
                    writer.WriteLine(yeut.ToString(), Encoding.UTF8);
                }
            }
        }


        public void Lichsudonhang(lichsudonhang lsdh)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lichsu");
            string filePath = Path.Combine(folderPath, "lichsudonhang.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                 writer.WriteLine(lsdh.ToString(), Encoding.UTF8);
            }
        }


        public void LichSuSanPham(lichsusanpham lssp)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lichsu");
            string filePath = Path.Combine(folderPath, "lichsuchitiet.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(lssp.ToString(), Encoding.UTF8);
            }
        }



        public void DanhGia(danhgia dg)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "danhgia.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(dg.ToString(), Encoding.UTF8);
            }
        }

        public void TKON(string tk, string email, string mk)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taikhoan");
            string filePath = Path.Combine(folderPath, "taikhoandangdangnhap.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{tk},{email},{mk}", Encoding.UTF8);
            }
        }

        public void SanPham(List<sanpham> sanpham)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "sanpham.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var sp in sanpham)
                {
                    if (sp.id[0] == 'B')
                    {
                        BanhMi bm = (BanhMi)sp;
                        writer.WriteLine(bm.ToString(), Encoding.UTF8);
                    }
                    if (sp.id[0] == 'C')
                    {
                        Caphe cp = (Caphe)sp;
                        writer.WriteLine(cp.ToString(), Encoding.UTF8);
                    }
                    if (sp.id[0] == 'G')
                    {
                        Giaikhat gk = (Giaikhat)sp;
                        writer.WriteLine(gk.ToString(), Encoding.UTF8);
                    }
                }
            }
        }
    }
}
