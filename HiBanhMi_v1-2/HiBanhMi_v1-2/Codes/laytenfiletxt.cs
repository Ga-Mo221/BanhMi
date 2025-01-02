using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class laytenfiletxt
    {
        public event EventHandler<Label> LabelClicked;
        public List<string> layten(string folderName)
        {
            // Đường dẫn tới folder (tương đối từ bin > debug)
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderName);

            try
            {
                // Kiểm tra nếu folder tồn tại
                if (Directory.Exists(folderPath))
                {
                    // Lấy danh sách file .txt
                    string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");

                    // Lấy tên file (không bao gồm đuôi)
                    List<string> fileNames = txtFiles.Select(file => Path.GetFileNameWithoutExtension(file)).ToList();

                    return fileNames;
                }
                else
                {
                    MessageBox.Show($"Folder '{folderName}' không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return new List<string>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<string>();
            }
        }


        public void themlable(FlowLayoutPanel fpn, List<string> filename, string colorgoc)
        {
            if (filename.Count > 0)
            {
                foreach (string file in filename)
                {
                    Label label = new Label()
                    {
                        Text = file,
                        BackColor = ColorTranslator.FromHtml(colorgoc),
                        ForeColor = Color.Black,
                        Font = new Font("JetBrains Mono NL SemiBold", 12, FontStyle.Regular),
                        Height = 30,
                        Width = 250
                    };

                    // Đăng ký sự kiện Click
                    label.Click += (s, e) =>
                    {
                        // Gọi sự kiện đã khai báo
                        LabelClicked?.Invoke(this, label);
                    };

                    fpn.Controls.Add(label);
                }
            }
        }
    }
}
