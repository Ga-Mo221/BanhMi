using System;
using System.IO;
using System.Windows.Forms;

namespace HiBanhMi_v1_1.Datacode
{
    internal class AddPhoto
    {

        public string ThemAnh(PictureBox pic)
        {
            string _selectedImagePath = null;
            // Tạo hộp thoại mở file
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif", // Lọc file chỉ hiển thị định dạng ảnh
                Title = "Chọn một file ảnh"
            };

            // Hiển thị hộp thoại và kiểm tra nếu người dùng nhấn OK
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đường dẫn file nguồn được chọn
                    _selectedImagePath = openFile.FileName;

                    // Hiển thị hình ảnh trong PictureBox
                    pic.ImageLocation = _selectedImagePath;
                }
                catch (Exception ex)
                {
                    // Xử lý nếu xảy ra lỗi
                    MessageBox.Show($"Đã xảy ra lỗi khi thêm ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return _selectedImagePath;
        }

        public void LuuAnh(string folderName, string _selectedImagePath)
        {
            if (string.IsNullOrEmpty(_selectedImagePath))
            {
                MessageBox.Show("Không có ảnh nào để lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thư mục bin/Debug
                string baseFolder = AppDomain.CurrentDomain.BaseDirectory;

                // Tạo đường dẫn đến thư mục đích
                string destinationFolder = Path.Combine(baseFolder, folderName);

                // Kiểm tra và tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Lấy tên file
                string fileName = Path.GetFileName(_selectedImagePath);

                // Tạo đường dẫn đích trong thư mục đích
                string destinationFile = Path.Combine(destinationFolder, fileName);

                // Copy file vào thư mục đích
                File.Copy(_selectedImagePath, destinationFile, overwrite: true);

                // Hiển thị thông báo thành công
                MessageBox.Show($"File đã được lưu vào: {destinationFolder}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý nếu xảy ra lỗi
                MessageBox.Show($"Đã xảy ra lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
