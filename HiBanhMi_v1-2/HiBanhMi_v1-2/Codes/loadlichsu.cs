using HiBanhMi_v1_2.Forms;
using HiBanhMi_v1_2.UseControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class loadlichsu
    {
        public void LoadLichsuDonHang(FlowLayoutPanel fpn)
        {
            if (listdh.dh != null)
            {
                foreach (var dh in listdh.dh)
                {
                    if (tkon.Tkc == dh.Iduser)
                    {
                        Lsdh lsdh = new Lsdh()
                        {
                            AA_txtmadon = NN.nn[70],
                            AA_txtthoigian = NN.nn[71],
                            AA_txttongtien = NN.nn[72],
                            AA_madon = dh.Ma,
                            AA_thoigian = dh.Tg,
                            AA_tongtien = dh.Tien
                        };

                        fpn.Controls.Add(lsdh);

                        lsdh.Click += (s, e) => lsdh_click(s, e, dh.Ma);
                    }
                }
            }
        }

        private void lsdh_click(object s, EventArgs e, string ma)
        {
            chitietdonhang Ctdh = new chitietdonhang();
            Ctdh.lb_madon.Text = ma;
            Ctdh.ShowDialog();
        }



        public void LoadChiTietDonHang(FlowLayoutPanel fpn, string madon)
        {
            foreach (var sp in listct.lssp)
            {
                if (madon == sp.Madon)
                {
                    Ctdh ctdh = new Ctdh()
                    {
                        AA_anh = img.LoadImageWithoutLocking(img.getpathImg("sanpham", sp.Img)),
                        AA_ten = sp.Ten,
                        AA_giagoc = sp.Giagoc,
                        AA_giacuoi = sp.Giacuoi,
                        AA_soluong = sp.Soluong,
                        AA_danhgia = NN.nn[32]
                    };
                    fpn.Controls.Add(ctdh);

                    ctdh.danhgia += (s, e) => danhgia_click(s, e, sp.Ma, sp.Img, sp.Ten);
                }
            }
        }

        private void danhgia_click(object s, EventArgs e, string ma, string Img, string ten)
        {
            // Tìm form chitietdonhang đang mở
            var openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is chitietdonhang) as chitietdonhang;

            if (openForm != null)
            {
                openForm.pn_danhgia.Visible = true;
                openForm.lb_ten.Text = ten;
                openForm.lb_masp.Text = ma;
                openForm.lb_img.Text = Img;
                openForm.panelCustom1.BackgroundImage = img.LoadImageWithoutLocking(img.getpathImg("sanpham", Img));
            }
        }
    }
}
