using HiBanhMi_v1_2.Codes;

internal class BanhMi : sanpham
{
    public int ngay_sale { get; set; }
    public int gio_sale { get; set; }
    public int daban { get; set; }
    public double danhgia { get; set; }
    public int luotdanhgia { get; set; }

    // Constructor mặc định
    public BanhMi() : base() { }

    // Constructor đầy đủ
    public BanhMi(string Id, string Img, string Ten, double Giagoc, int Sale, int Soluong, int Ngay_sale, int Gio_sale, int Daban, double Danhgia, int Luotdanhgia)
        : base(Id, Img, Ten, Giagoc, Sale, Soluong)
    {
        ngay_sale = Ngay_sale;
        gio_sale = Gio_sale;
        daban = Daban;
        danhgia = Danhgia;
        luotdanhgia = Luotdanhgia;
    }

    // Constructor sao chép
    public BanhMi(BanhMi banhMi)
        : this(banhMi.id, banhMi.img, banhMi.ten, banhMi.giagoc, banhMi.sale, banhMi.soluong, banhMi.ngay_sale, banhMi.gio_sale, banhMi.daban, banhMi.danhgia, banhMi.luotdanhgia) { }

    // Ghi đè phương thức ToString
    public override string ToString()
    {
        return $"{base.ToString()},{ngay_sale},{gio_sale},{daban},{danhgia},{luotdanhgia}";
    }
}
