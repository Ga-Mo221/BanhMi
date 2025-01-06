using System.Collections.Generic;

internal class sanpham
{
    public string id { get; set; }
    public string img { get; set; }
    public string ten { get; set; }
    public double giagoc { get; set; }
    public int sale { get; set; }
    public int soluong { get; set; }
    public double giacuoi { get; set; }

    // Tính giá cuối cùng (tối ưu hóa với thuộc tính chỉ đọc)
    public double Gia()
    {
        return giagoc * (1 - (sale / 100.0));
    }

    // Constructor mặc định
    public sanpham() { }

    // Constructor đầy đủ
    public sanpham(string id, string img, string ten, double giagoc, int sale, int soluong)
    {
        this.id = id;
        this.img = img;
        this.ten = ten;
        this.giagoc = giagoc;
        this.sale = sale;
        this.soluong = soluong;
        this.giacuoi = this.Gia();
    }

    // Constructor sao chép
    public sanpham(sanpham sp)
    {
        this.id = sp.id;
        this.img = sp.img;
        this.ten = sp.ten;
        this.giagoc = sp.giagoc;
        this.sale = sp.sale;
        this.soluong = sp.soluong;
        this.giacuoi = this.Gia();
    }

    // Ghi đè phương thức ToString
    public override string ToString()
    {
        return $"{id},{img},{ten},{giagoc},{sale},{soluong}";
    }

}

internal static class listsp
{
    public static List<sanpham> sanphams = new List<sanpham>() ;
}
