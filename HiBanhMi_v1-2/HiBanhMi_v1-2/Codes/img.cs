using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class img
    {
        public static user addimg(string userId, PictureBox pictureBox)
        {
            GhiFile ghi = new GhiFile();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Tạo đường dẫn thư mục folder
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "avatar");
                    Directory.CreateDirectory(folderPath);

                    // Tên file mới là ID + đuôi file
                    string fileExtension = Path.GetExtension(selectedFilePath);
                    string newFileName = $"{userId}{fileExtension}";
                    string destinationPath = Path.Combine(folderPath, newFileName);

                    // Sao chép file vào Resources và đổi tên
                    File.Copy(selectedFilePath, destinationPath, overwrite: true);

                    // Cập nhật AvatarPath cho user hiện tại
                    user currentUser = new user(newFileName, uson.users.taikhoan, uson.users.hoten, uson.users.sdt, uson.users.sinhnhat, uson.users.diachi, uson.users.nickname, uson.users.gioitinh);
                    

                    // Hiển thị ảnh trong PictureBox
                    if (pictureBox != null)
                    {
                        pictureBox.Image = Image.FromFile(destinationPath);
                        foreach (user us in userlist.users)
                        {
                            if (us.taikhoan == uson.users.taikhoan)
                            {
                                us.avata = newFileName;
                            }
                        }
                        ghi.userprofile(userlist.users);
                    }

                    return currentUser;
                }
            }

            return null;
        }

        public static string getpathImg(string filename)
        {
            // Đường dẫn thư mục "avatar"
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "avatar");
            Directory.CreateDirectory(folderPath); // Đảm bảo thư mục tồn tại

            // Kết hợp thư mục với tên file để tạo đường dẫn đầy đủ
            string fullPath = Path.Combine(folderPath, filename);
            return fullPath;
        }

    }
}
