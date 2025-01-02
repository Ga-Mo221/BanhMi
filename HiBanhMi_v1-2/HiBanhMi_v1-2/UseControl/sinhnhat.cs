using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.UseControl
{
    public partial class sinhnhat : UserControl
    {
        int speed;
        public string[] ngay;
        public string[] thang;
        public string[] nam;
        public string colobg;
        public string colochon;
        public int Ngay;
        public int Thang;
        public int Nam;



        public sinhnhat()
        {
            InitializeComponent();
            speed = 10;
            colobg = "#f87192";
            colochon = "#ec6083";
            Ngay = 0; Thang = 0; Nam = 0;
            label1.ForeColor = Color.Black;
            lb_sinhnhat.ForeColor = Color.Black;
        }


        public string AA_sinhnhat
        {
            get => lb_sinhnhat.Text;
            set { lb_sinhnhat.Text = value; Invalidate(); }
        }
        public Color AA_bgrcolor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }
        public string AA_title
        {
            get => label1.Text;
            set { label1.Text = value; Invalidate(); }
        }
        public string AA_mauLBitem
        {
            set { colobg = value; Invalidate(); }
            get => colobg;
        }
        public string AA_mauLBduocchon
        {
            get => colochon;
            set => colochon = value;
        }
        public int AA_Ngay
        {
            get => Ngay;
            set => Ngay = value;
        }
        public int AA_Thang
        {
            get => Thang;
            set => Thang = value;
        }
        public int AA_Nam
        {
            get => Nam;
            set => Nam = value;
        }


        public string[] AA_ngayList
        {
            get => ngay;
            set
            {
                if (value == null) return;
                ngay = value;

                fpn_ngay.Controls.Clear(); // Xóa các Label cũ trước khi thêm mới
                foreach (var item in ngay)
                {
                    Label label = new Label
                    {
                        Text = item,
                        ForeColor = Color.Black,
                        BackColor = ColorTranslator.FromHtml(colobg),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Height = 25,
                        Width = 72
                    };

                    label.MouseClick += new MouseEventHandler(ngay_chon);
                    fpn_ngay.Controls.Add(label);
                }
                Invalidate();
            }
        }

        private void ngay_chon(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            label.BackColor = ColorTranslator.FromHtml(colochon);
            Ngay = int.Parse(label.Text); // Cập nhật giá trị ngày
            kiemtra();
        }


        public string[] AA_thangList
        {
            get => thang;
            set
            {
                if (value == null) return;
                thang = value;

                fpn_thang.Controls.Clear(); // Xóa các Label cũ trước khi thêm mới
                foreach (var item in thang)
                {
                    Label label = new Label
                    {
                        Text = item,
                        ForeColor = Color.Black,
                        BackColor = ColorTranslator.FromHtml(colobg),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Height = 25,
                        Width = 72
                    };

                    label.MouseClick += new MouseEventHandler(thang_chon);
                    fpn_thang.Controls.Add(label);
                }
                Invalidate();
            }
        }

        private void thang_chon(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            label.BackColor = ColorTranslator.FromHtml(colochon);
            Thang = int.Parse(label.Text); // Cập nhật giá trị tháng
            kiemtra();
        }


        public string[] AA_namList
        {
            get => nam;
            set
            {
                if (value == null) return; // Tránh lỗi nếu giá trị được đặt là null.
                nam = value;

                fpn_nam.Controls.Clear(); // Xóa các Label cũ để tránh trùng lặp.
                foreach (var item in nam)
                {
                    Label label = new Label
                    {
                        Text = item,
                        ForeColor = Color.Black,
                        BackColor = ColorTranslator.FromHtml(colobg),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Height = 25,
                        Width = 72
                    };

                    label.MouseClick += new MouseEventHandler(nam_chon);
                    fpn_nam.Controls.Add(label);
                }
                Invalidate();
            }
        }

        private void nam_chon(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            label.BackColor = ColorTranslator.FromHtml(colochon);
            Nam = int.Parse(label.Text); // Cập nhật giá trị năm
            kiemtra();
        }

        private void kiemtra()
        {
            if (Ngay != 0 && Thang != 0 && Nam != 0)
            {
                lb_sinhnhat.Text = Ngay.ToString() + "-" + Thang.ToString() + "-" + Nam.ToString();
                tglen.Start();
            }
        }



        public int AA_speed
        {
            get { return speed; }
            set { speed = value; Invalidate(); }
        }

        private void tgxuong_Tick(object sender, EventArgs e)
        {
            tglen.Stop();
            Height += speed;
            if (Height >= 200) tgxuong.Stop();
        }

        private void tglen_Tick(object sender, EventArgs e)
        {
            tgxuong.Stop();
            Height -= speed;
            if (Height == 50) tglen.Stop();
        }

        private void lb_sinhnhat_Click(object sender, EventArgs e)
        {
            if (Height <= 50)
            {
                tgxuong.Start();
            }
            else if (Height >= 200) tglen.Start();
        }
    }
}
