using System;
using System.Collections.Generic;
using System.Linq;

internal class GioHang
{
    // Danh sách sản phẩm trong giỏ hàng
    private List<sanpham> danhSachSanPham;

    public GioHang()
    {
        danhSachSanPham = new List<sanpham>();
    }

    // Thêm sản phẩm vào giỏ hàng
    public void ThemSanPham(sanpham sp)
    {
        var spTonTai = danhSachSanPham.FirstOrDefault(p => p.id == sp.id);
        if (spTonTai != null)
        {
            spTonTai.soluong += sp.soluong; // Nếu sản phẩm đã tồn tại, tăng số lượng
        }
        else
        {
            danhSachSanPham.Add(sp);
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
            Console.WriteLine($"Không tìm thấy sản phẩm có ID: {id}");
        }
    }

    // Tính tổng giá trị giỏ hàng
    public double TinhTongGiaTri()
    {
        return danhSachSanPham.Sum(sp => sp.giacuoi * sp.soluong);
    }

    // Hiển thị danh sách sản phẩm trong giỏ hàng
    public void HienThiGioHang()
    {
        Console.WriteLine("Danh sách sản phẩm trong giỏ hàng:");
        foreach (var sp in danhSachSanPham)
        {
            Console.WriteLine(sp.ToString());
        }
        Console.WriteLine($"Tổng giá trị giỏ hàng: {TinhTongGiaTri():C}");
    }
}
