using HiBanhMi_v1_2.Codes;
using HiBanhMi_v1_2.UseControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Forms
{
    public partial class giohang : Form
    {
        public giohang()
        {
            InitializeComponent();

            Size = new Size(600, 500);

            //MessageBox.Show(GioHang.soluongsanpham.ToString());
            LoatGioHang();
            lb_tongtien.Text = GioHang.tonggia.ToString();

            //set ngonngu
            setngonngu();
            //setcolor
            setcolor();
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan();
            tt.tt();
            fpn.Controls.Clear();
            
        }


        //------------------------------------------------------------------------
        private void LoatGioHang()
        {
            if (GioHang.soluongsanpham > 0)
            {
                foreach (var sp in GioHang.danhSachSanPham)
                {
                    ItemTrongGioHang Item = new ItemTrongGioHang()
                    {
                        AA_masp = sp.id,
                        AA_ten = sp.ten,
                        AA_giacuoi = sp.giacuoi.ToString(),
                        AA_giagoc = sp.giagoc.ToString(),
                        AA_sale = sp.sale.ToString(),
                        AA_soluong = sp.soluong.ToString()
                    };
                    fpn.Controls.Add(Item);

                    Item.xoa += Item_xoa;
                    Item.tang += Item_tang;
                    Item.giam += Item_giam;
                }
            }
        }

        private void Item_giam(object sender, EventArgs e)
        {
            ItemTrongGioHang it = sender as ItemTrongGioHang;
            xulygiamsl(it);
        }

        private void Item_tang(object sender, EventArgs e)
        {
            ItemTrongGioHang it = sender as ItemTrongGioHang;
            xulytangsl(it);
        }

        private void Item_xoa(object sender, EventArgs e)
        {
            ItemTrongGioHang it = sender as ItemTrongGioHang;
            xulyxoa(it);
        }

        //--------------------------------------------------------------------------------
        private void xulygiamsl(ItemTrongGioHang it)
        {
            GioHang.soluongsanpham -= 1;
            GioHang.tonggia -= int.Parse(it.AA_giacuoi);
            lb_tongtien.Text = GioHang.tonggia.ToString();

            foreach (var sp in GioHang.danhSachSanPham)
            {
                if (it.AA_masp == sp.id)
                {
                    sp.soluong = int.Parse(it.AA_soluong);
                    sp.giacuoi = double.Parse(it.AA_giacuoi);
                }
            }
        }
        private void xulytangsl(ItemTrongGioHang it)
        {
            GioHang.soluongsanpham += 1;
            GioHang.tonggia += int.Parse(it.AA_giacuoi);
            lb_tongtien.Text = GioHang.tonggia.ToString();

            foreach (var sp in GioHang.danhSachSanPham)
            {
                if (it.AA_masp == sp.id)
                {
                    sp.soluong = int.Parse(it.AA_soluong);
                    sp.giacuoi = double.Parse(it.AA_giacuoi);
                }
            }
        }

        private void xulyxoa(ItemTrongGioHang it)
        {
            sanpham spToRemove = null;
            foreach (var sp in GioHang.danhSachSanPham)
            {
                if (sp.id == it.AA_masp)
                {
                    spToRemove = sp;
                    break; // Khi đã tìm thấy sản phẩm cần xóa, không cần tiếp tục lặp
                }
            }

            if (spToRemove != null)
            {
                // Xóa sản phẩm khỏi giỏ hàng
                GioHang.danhSachSanPham.Remove(spToRemove);
                GioHang.soluongsanpham -= int.Parse(it.AA_soluong);
                GioHang.tonggia -= int.Parse(it.AA_soluong) * double.Parse(it.AA_giacuoi);

                // Xóa item khỏi FlowLayoutPanel giỏ hàng
                fpn.Controls.Remove(it);

                // Cập nhật lại tổng tiền
                lb_tongtien.Text = GioHang.tonggia.ToString();
            }
        }














        private void setngonngu()
        {
            lb_giohang.Text = NN.nn[63];
            bt_thanhtoan.Text = NN.nn[65];
        }
        private void setcolor()
        {
            panel1.BackColor = ColorTranslator.FromHtml(THEME.t[3]);
            bt_thanhtoan.BackColor = ColorTranslator.FromHtml (THEME.t[2]);
            BackColor = ColorTranslator.FromHtml (THEME.t[1]);
            bt_exit.BackColor = ColorTranslator.FromHtml(THEME.t[3]);
        }

    }
}
