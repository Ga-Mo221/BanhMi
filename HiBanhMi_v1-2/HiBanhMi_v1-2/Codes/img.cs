using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class img
    {
        // Hàm thêm ảnh vào thư mục avatar và cập nhật user
        public static user addimg(string userId, PictureBox pictureBox)
        {
            GhiFile ghi = new GhiFile();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    // Tạo thư mục avatar nếu chưa tồn tại
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "avatar");
                    

                    // Tạo tên file mới dựa trên userId
                    string fileExtension = Path.GetExtension(selectedFilePath);
                    string newFileName = $"{userId}{fileExtension}";
                    string destinationPath = Path.Combine(folderPath, newFileName);

                    try
                    {
                        Console.WriteLine("bat dau");
                        // Nếu file đích đã tồn tại, sẽ ghi đè
                        try
                        {
                            // Nếu ảnh đang được hiển thị trong PictureBox, giải phóng tài nguyên ảnh
                            if (pictureBox.Image != null)
                            {
                                pictureBox.Image.Dispose();  // Giải phóng tài nguyên của ảnh
                                pictureBox.Image = null;     // Đặt lại ảnh trong PictureBox
                            }
                            if (File.Exists(destinationPath))
                            {
                                // Nếu file chỉ đọc, thay đổi thuộc tính để có thể xóa
                                File.SetAttributes(destinationPath, FileAttributes.Normal);
                                File.Delete(destinationPath);
                                Console.WriteLine($"Đã xóa file: {destinationPath}");
                            }
                            else
                            {
                                Console.WriteLine($"File không tồn tại: {destinationPath}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Đã xảy ra lỗi khi xóa file: {ex.Message}");
                        }


                        // Sao chép file ảnh vào thư mục
                        Console.WriteLine("bat dau sao chep");
                        File.Copy(selectedFilePath, destinationPath);
                        Console.WriteLine($"file da ghi de thanh cong: {destinationPath}");
                        Console.WriteLine("sao chep");
                        // Cập nhật avatar cho user
                        user currentUser = new user(newFileName, uson.users.taikhoan, uson.users.hoten, uson.users.sdt, uson.users.sinhnhat, uson.users.diachi, uson.users.nickname, uson.users.gioitinh);

                        // Hiển thị ảnh trong PictureBox
                        if (pictureBox != null)
                        {
                            pictureBox.Image = LoadImageWithoutLocking(destinationPath);
                        }

                        // Cập nhật thông tin avatar trong danh sách user
                        foreach (user us in userlist.users)
                        {
                            if (us.taikhoan == uson.users.taikhoan)
                            {
                                us.avata = newFileName;
                                uson.users.avata = newFileName;
                            }
                        }

                        // Ghi lại thông tin người dùng vào profile
                        ghi.userprofile(userlist.users);

                        return currentUser;  // Trả về user với avatar mới
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"da xay ra loi: {ex.Message}");
                        return null;
                    }
                }
            }

            return null;  // Trả về null nếu không chọn file
        }

        // Hàm lấy đường dẫn đầy đủ của ảnh từ tên file
        public static string getpathImg(string foldername, string filename)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,foldername);

            // Đảm bảo thư mục tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Kết hợp đường dẫn thư mục với tên file để tạo đường dẫn đầy đủ
            return Path.Combine(folderPath, filename);
        }

        // Hàm tải ảnh từ đường dẫn mà không bị khóa file
        public static Image LoadImageWithoutLocking(string path)
        {
            try
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);  // Đọc ảnh từ file stream và trả về đối tượng Image
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải ảnh: {ex.Message}");
                return null;  // Trả về null nếu có lỗi khi tải ảnh
            }
        }
    }
}
