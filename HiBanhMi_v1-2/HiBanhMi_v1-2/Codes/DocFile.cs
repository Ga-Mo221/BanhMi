using HiBanhMi_v1_2.UseControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class DocFile
    {
        // Đọc file tài khoản
        public void TaiKhoan(List<TaiKhoan> taikhoan)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taikhoan");
            string filePath = Path.Combine(folderPath, "taikhoan.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string tk = parts[0];
                    string email = parts[1];
                    string mk = parts[2];
                    
                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    taikhoan.Add(new TaiKhoan(tk, email, mk));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file taikhoan để đọc","lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Đọc file Ngôn Ngữ
        public void Ngongu(List<string> ngonngu, string tenNN)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ngonngu");
            string filePath = Path.Combine(folderPath, tenNN+".txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    ngonngu.Add(line);
                }
            }
            else
            {
                MessageBox.Show($"không tồn tại {filePath} để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Đọc file color
        public void Theme(List<string> Theme, string tenTheme)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "theme");
            string filePath = Path.Combine(folderPath, tenTheme+".txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    Theme.Add(line);
                }
            }
            else
            {
                MessageBox.Show($"không tồn tại {filePath} để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Đọc file use setting
        public void US(List<string> us)
        {
            // lấy đường dẫn
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "setting");
            string filePath = Path.Combine(folderPath,"usersetting.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    string ngonngu = parts[0];
                    string theme = parts[1];

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    us.Add(ngonngu);
                    us.Add(theme);
                }
            }
            else
            {
                MessageBox.Show($"không tồn tại {filePath} để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void users(List<user> userDetails)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users");
            string filePath = Path.Combine(folderPath, "users.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string tk = parts[0];
                    string hoten = parts[1];
                    string nickname = parts[2];
                    string sdt = parts[3];
                    string gioitinh = parts[4];
                    string diachi = parts[5];
                    string sinhnhat = parts[6];
                    string avata = parts[7];

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    userDetails.Add(new user(avata, tk, hoten, sdt, sinhnhat, diachi, nickname, gioitinh));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file taikhoan để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
