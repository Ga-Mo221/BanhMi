using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiBanhMi
{
    internal class ImageManager
    {
        private string duoi = ".PNG"; // Phần đuôi file ảnh (ví dụ: ".png", ".jpg")

        public ImageManager() { }

        /// <summary>
        /// Tải ảnh từ thư mục "DangNhapPhoTo" trong thư mục ứng dụng.
        /// </summary>
        /// <param name="nameimg">Tên file ảnh không bao gồm phần đuôi.</param>
        /// <returns>Đối tượng LoatIMG đại diện cho ảnh đã tải, hoặc null nếu có lỗi.</returns>
        public void LoadImage(PictureBox pic , string namefolder, string nameimg)
        {
            Bitmap bm = new Bitmap(Application.StartupPath + "\\" + namefolder + "\\" + nameimg + duoi);
            pic.Image = bm;
        }


        public void LoadImage(Button button, string namefolder, string nameimg)
        {
            Bitmap bm = new Bitmap(Application.StartupPath + "\\" + namefolder + "\\" + nameimg + duoi);
            button.BackgroundImage = bm;
        }
    }
}
