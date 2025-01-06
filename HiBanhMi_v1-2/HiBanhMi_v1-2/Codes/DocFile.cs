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

        public void sanpham(List<sanpham> listsp)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "sanpham.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string Id = parts[0];
                    string Img = parts[1]; 
                    string Ten = parts[2];
                    double Giagoc = Double.Parse( parts[3]); 
                    int Sale = int.Parse( parts[4]); 
                    int Soluong = int.Parse(parts[5]); 
                    int Daban = int.Parse(parts[6]); 
                    double Danhgia = Double.Parse(parts[7]); 
                    int Luotdanhgia = int.Parse(parts[8]);

                    switch (Id[0])
                    {
                        case 'B':
                            {
                                BanhMi bm = new BanhMi(Id, Img, Ten, Giagoc, Sale, Soluong, Daban, Danhgia, Luotdanhgia);
                                listsp.Add(bm);
                                break;
                            }
                        case 'C':
                            {
                                Caphe cp = new Caphe(Id, Img, Ten, Giagoc, Sale, Soluong, Daban, Danhgia, Luotdanhgia);
                                listsp.Add(cp);
                                break;
                            }
                        case 'G':
                            {
                                Giaikhat gk = new Giaikhat(Id, Img, Ten, Giagoc, Sale, Soluong, Daban, Danhgia, Luotdanhgia);
                                listsp.Add(gk);
                                break;
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file sanpham để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void YeuThich(List<yeuthich> yt)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "spyeuthich.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string iduse = parts[0];
                    string idsp = parts[1];
                    int chiso = int.Parse(parts[2]);

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    yt.Add(new yeuthich(iduse, idsp, chiso));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file spyeuthich để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void lichsudonhang(List<lichsudonhang> lsdh)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lichsu");
            string filePath = Path.Combine(folderPath, "lichsudonhang.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string madon = parts[0];
                    string iduser = parts[1];
                    string thoigian = parts[2];
                    string tien = parts[3];

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    lsdh.Add(new lichsudonhang(madon, iduser, thoigian, tien));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file lichsudonhang để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LichSuSanPham(List<lichsusanpham> lssp)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lichsu");
            string filePath = Path.Combine(folderPath, "lichsuchitiet.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "," }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string madon = parts[0];
                    string iduser = parts[1];
                    string masp = parts[2];
                    string img = parts[3];
                    string ten = parts[4];
                    string soluong = parts[5];
                    string giagoc = parts[6];
                    string giacuoi = parts[7];

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    lssp.Add(new lichsusanpham(madon, iduser, masp, img, ten, soluong, giagoc, giacuoi));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file lichsudonhang để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void DanhGia(List<danhgia> dg)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sanpham");
            string filePath = Path.Combine(folderPath, "danhgia.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                foreach (string line in lines)
                {
                    // tách thông tin từ dòng
                    string[] parts = line.Split(new[] { "|" }, StringSplitOptions.None);

                    // lấy thông tin từ chuỗi
                    string masp = parts[0];
                    string img = parts[1];
                    string user = parts[2];
                    string chude = parts[3];
                    string noidung = parts[4];

                    // Tạo đối tượng taikhoan và thêm vào danh sách
                    dg.Add(new danhgia(masp, img, user, chude, noidung));
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file danhgia để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TKON (List<string> list)
        {
            // Đường dẫn tới file
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taikhoan");
            string filePath = Path.Combine(folderPath, "taikhoandangdangnhap.txt");

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
                    list.Add(tk);
                    list.Add(email);
                    list.Add(mk);
                }
            }
            else
            {
                MessageBox.Show("không tồn tại file taikhoandangdangnhap để đọc", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
