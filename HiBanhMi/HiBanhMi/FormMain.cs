using HiBanhMi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HiBanhMi
{
    public partial class FormMain : Form
    {
        // biến
        ImageManager taianh = new ImageManager();
        Chude c = new Chude();
        TaiForm taif = new TaiForm();
        Form formchinh;
        FormBatDau formbatdau = new FormBatDau();


        public FormMain()
        {
            InitializeComponent();

            // form chính
            this.Size = new Size(1000, 562);
            // pnMain
            pnMain.Dock = DockStyle.Fill;

            // thanh Exit Scale An
            pnESA.Size = new Size(90, 30);
            pnESA.Location = new Point(910, 0);

            // 3 nút trên thanh tiêu đề
            //btExit
            btExit.Size = new Size(30, 30);
            btExit.Location = new Point(60, 0);
            taianh.LoadImage(btExit, "DangNhapPhoTo", "Exit");

            //btScale
            btScale.Size = new Size(30, 30);
            btScale.Location = new Point(30, 0);
            taianh.LoadImage(btScale, "DangNhapPhoTo", "ScaleMax");

            //btAn
            btAn.Size = new Size(30, 30);
            btAn.Location = new Point(0, 0);
            taianh.LoadImage(btAn, "DangNhapPhoTo", "An");

            taiform();
        }



        // thanh tiêu đề 
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btScale_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
                taianh.LoadImage(btScale, "DangNhapPhoTo", "ScaleMin");
                formbatdau.pnchon.Location = new Point(0,0);
                formbatdau.pnchon.Size = new Size(10, 562);
                formbatdau.pnchon.BackColor = Color.FromArgb(c.M(c.banhmivang("nen"), 0), c.M(c.banhmivang("nen"), 1), c.M(c.banhmivang("nen"), 2));
                formbatdau.pnchon.Refresh();
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Trở lại kích thước ban đầu
                this.StartPosition = FormStartPosition.CenterScreen;
                taianh.LoadImage(btScale, "DangNhapPhoTo", "ScaleMax");
                formbatdau.pnchon.Location = new Point(0, 0);
                formbatdau.pnchon.Size = new Size(200, 562);
                formbatdau.pnchon.BackColor = Color.FromArgb(c.M(c.banhmivang("nen"), 0), c.M(c.banhmivang("nen"), 1), c.M(c.banhmivang("nen"), 2));
                formbatdau.pnchon.Refresh();
            }
        }

        private void btAn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ ứng dụng
        }



        int solandangnhap = 2;
        // tải form
        private void taiform()
        {
            if (solandangnhap == 1)
            {
                //chua lam gi
            }
            else
            {
                taif.openchildform(pnMain, formchinh, new Forms.FormBatDau());
            }
            pnESA.BringToFront();
        }
    }
}
