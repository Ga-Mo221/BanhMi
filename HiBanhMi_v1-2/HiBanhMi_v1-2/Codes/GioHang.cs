using HiBanhMi_v1_2.UseControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

internal class GioHang
{
    // Danh sách sản phẩm trong giỏ hàng
    public static List<sanpham> danhSachSanPham = new List<sanpham>();
    public static int soluongsanpham = 0;
    public static double tonggia = 0;

    public GioHang(){}

    // Thêm sản phẩm vào giỏ hàng
    public void ThemSanPham(sanpham sp)
    {
        danhSachSanPham.Add(sp);
    }

    public void Tangsoluong(string id)
    {
        foreach (var sp in danhSachSanPham)
        {
            if (sp.id == id)
            {
                sp.soluong++;
            }
        }
    }

    // Xóa sản phẩm khỏi giỏ hàng
    public void XoaSanPham(string id)
    {
        var sp = danhSachSanPham.FirstOrDefault(p => p.id == id);
        if (sp != null)
        {
            danhSachSanPham.Remove(sp);
        }
        else
        {
            MessageBox.Show($"Không tìm thấy sản phẩm có ID: {id}", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // Tính tổng giá trị giỏ hàng
    public double TinhTongGiaTri()
    {
        return danhSachSanPham.Sum(sp => sp.giacuoi * sp.soluong);
    }




    private void xulygiamsl(itemingiohang it, Label tongtien)
    {
        GioHang.soluongsanpham -= 1;
        GioHang.tonggia -= int.Parse(it.AA_gia);
        tongtien.Text = GioHang.tonggia.ToString();

        foreach (var sp in GioHang.danhSachSanPham)
        {
            if (it.AA_masp == sp.id)
            {
                sp.soluong = int.Parse(it.AA_soluong);
                sp.giacuoi = double.Parse(it.AA_gia);
            }
        }
    }
    private void xulytangsl(itemingiohang it, Label tongtien)
    {
        GioHang.soluongsanpham += 1;
        GioHang.tonggia += int.Parse(it.AA_gia);
        tongtien.Text = GioHang.tonggia.ToString();

        foreach (var sp in GioHang.danhSachSanPham)
        {
            if (it.AA_masp == sp.id)
            {
                sp.soluong = int.Parse(it.AA_soluong);
                sp.giacuoi = double.Parse(it.AA_gia);
            }
        }
    }
    private void xulyxoa(itemingiohang it, FlowLayoutPanel fpn_gh, Label tongtien)
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
            GioHang.tonggia -= int.Parse(it.AA_soluong) * double.Parse(it.AA_gia);

            // Xóa item khỏi FlowLayoutPanel giỏ hàng
            fpn_gh.Controls.Remove(it);

            // Cập nhật lại tổng tiền
            tongtien.Text = GioHang.tonggia.ToString();
        }
    }

    public void loadGH(FlowLayoutPanel fpn, Label tongtien)
    {
        if (GioHang.danhSachSanPham != null)
        {
            foreach (var sp in GioHang.danhSachSanPham)
            {
                itemingiohang it = new itemingiohang()
                {
                    AA_masp = sp.id,
                    AA_ten = sp.ten,
                    AA_gia = sp.giacuoi.ToString(),
                    AA_sale = sp.sale.ToString(),
                    AA_soluong = sp.soluong.ToString(),
                };

                fpn.Controls.Add(it);

                it.xoa += (se, ee) => xoaclick(se, ee, fpn, tongtien);
                it.tang += (se, ee) => tangsoln(se, ee, fpn, tongtien);
                it.giam += (se, ee) => giamsoln(se, ee, fpn, tongtien);
            }
            tongtien.Text = GioHang.tonggia.ToString();
        }
    }

    private void giamsoln(object se, EventArgs ee, FlowLayoutPanel fpn, Label tongtien)
    {
        itemingiohang it = se as itemingiohang;
        xulygiamsl(it, tongtien);
    }

    private void tangsoln(object se, EventArgs ee, FlowLayoutPanel fpn, Label tongtien)
    {
        itemingiohang it = se as itemingiohang;
        xulytangsl(it, tongtien);
    }

    private void xoaclick(object se, EventArgs ee, FlowLayoutPanel fpn, Label tongtien)
    {
        itemingiohang it = se as itemingiohang;
        xulyxoa(it, fpn, tongtien);
    }
}
