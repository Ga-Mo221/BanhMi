using HiBanhMi_v1_2.Forms;
using HiBanhMi_v1_2.UseControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiBanhMi_v1_2.Codes
{
    internal class loaditem
    {
        GhiFile ghi = new GhiFile();


        public void Load(FlowLayoutPanel fpn, string sp)
        {
            switch (sp)
            {
                case "TC":
                    {
                        fpn.Controls.Clear();
                        addTC(fpn);
                        break;
                    }
                case "BM":
                    {
                        fpn.Controls.Clear();
                        addBM(fpn);
                        break;
                    }
                case "CP":
                    {
                        fpn.Controls.Clear();
                        addCP(fpn);
                        break;
                    }
                case "GK":
                    {
                        fpn.Controls.Clear();
                        addGK(fpn);
                        break;
                    }
            }
        }







        private void xoatim(FlowLayoutPanel fpn, item Item)
        {
            yeuthich yeut = new yeuthich();
            foreach (var yt in listyt.yt)
            {
                if (yt.Iduse == tkon.Tkc)
                {
                    if (Item.AA_masp == yt.Masp)
                    {
                        yeut = yt;
                    }
                }
            }

            if (yeut != null)
            {
                listyt.yt.Remove(yeut);
                ghi.YeuThich(listyt.yt);
                fpn.Controls.Remove(Item);
            }
        }
        private void MuaTrongYeuThich(item Item)
        {
            sanpham sp = new sanpham();
            Item.AA_sudungnutthem = false;
            foreach (var SP in listsp.sanphams)
            {
                if (Item.AA_masp == SP.id)
                {
                    sp = new sanpham(SP);
                }
            }
            GioHang.danhSachSanPham.Add(sp);
            GioHang.soluongsanpham += sp.soluong;
            GioHang.tonggia += sp.giacuoi;
        }







        //---------thêm bánh mì
        private void addBM(FlowLayoutPanel fpn)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "B" && i is BanhMi bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(bm,Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", bm.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = bm.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_hienthitim = false;
                        Item.AA_nutmua = false;
                    }

                    fpn.Controls.Add(Item);
                }
            }
        }



        //---------thêm cà phê
        private void addCP(FlowLayoutPanel fpn)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "C" && i is Caphe cp)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_tensp = cp.ten,
                        AA_daban = cp.daban.ToString(),
                        AA_danhgia = cp.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = cp.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(cp, Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", cp.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = cp.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_hienthitim = false;
                        Item.AA_nutmua = false;
                    }

                    fpn.Controls.Add(Item);
                }
            }
        }



        //---------thêm giải khát
        private void addGK(FlowLayoutPanel fpn)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "G" && i is Giaikhat gk)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_tensp = gk.ten,
                        AA_daban = gk.daban.ToString(),
                        AA_danhgia = gk.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = gk.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(gk, Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", gk.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = gk.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_hienthitim = false;
                        Item.AA_nutmua = false;
                    }


                    fpn.Controls.Add(Item);
                }
            }
        }





        //---------thêm tất cả
        private void addTC(FlowLayoutPanel fpn)
        {
            addBM(fpn);
            addCP(fpn);
            addGK(fpn);
        }


        //--------------------------------------------------------------------------------------









        public void Load(FlowLayoutPanel fpn, FlowLayoutPanel fpn_gh, Label tongtien, string sp)
        {
            switch (sp)
            {
                case "TC":
                    {
                        fpn.Controls.Clear();
                        addTC(fpn, fpn_gh, tongtien);
                        break;
                    }
                case "BM":
                    {
                        fpn.Controls.Clear();
                        addBM(fpn, fpn_gh, tongtien);
                        break;
                    }
                case "CP":
                    {
                        fpn.Controls.Clear();
                        addCP(fpn, fpn_gh, tongtien);
                        break;
                    }
                case "GK":
                    {
                        fpn.Controls.Clear();
                        addGK(fpn, fpn_gh, tongtien);
                        break;
                    }
            }
        }




        private void KiemTraItemTrongGioHang(item Item)
        {
            if (GioHang.soluongsanpham != 0)
            {
                foreach (var sp in GioHang.danhSachSanPham)
                {
                    if (Item.AA_masp == sp.id)
                    {
                        Item.AA_anhnutthem = Properties.Resources.tick;
                        Item.AA_sudungnutthem = false;
                    }
                }
            }
        }


        private itemingiohang xulynutmua(item Item, Label tongtien)
        {
            sanpham sp = new sanpham();
            Item.AA_sudungnutthem = false;
            foreach (var SP in listsp.sanphams)
            {
                if (Item.AA_masp == SP.id)
                {
                    sp = new sanpham(SP);
                }
            }
            GioHang.danhSachSanPham.Add(sp);
            GioHang.soluongsanpham += sp.soluong;
            GioHang.tonggia += sp.giacuoi;
            tongtien.Text = GioHang.tonggia.ToString();
            itemingiohang it = new itemingiohang()
            {
                AA_masp = sp.id,
                AA_ten = sp.ten,
                AA_gia = sp.giacuoi.ToString(),
                AA_sale = sp.sale.ToString(),
                AA_soluong = sp.soluong.ToString(),
            };
            return it;
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
        private void xulyxoa(itemingiohang it, FlowLayoutPanel fpn_gh, Label tongtien, item Item)
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
            Item.AA_sudungnutthem = true;
            Item.AA_anhnutthem = Properties.Resources.add;
        }

        private void xulytim(item Item)
        {
            if (Item.AA_thich == 1)
            {
                listyt.yt.Add(new yeuthich(tkon.Tkc, Item.AA_masp, 1));
                ghi.YeuThich(listyt.yt);
            }
            if (Item.AA_thich == 0)
            {
                yeuthich yeut = new yeuthich();
                foreach (var yt in listyt.yt)
                {
                    if (tkon.Tkc == yt.Iduse)
                    {
                        if (Item.AA_masp == yt.Masp)
                        {
                            yeut = yt;
                        }
                    }
                }

                if (yeut != null)
                {
                    listyt.yt.Remove(yeut);
                    Item.AA_anhtim = Properties.Resources.likeden;
                    ghi.YeuThich(listyt.yt);
                }
            }
        }


        //-----------------------------------------------------------------------------------------------------------------
        //---------------------------them banh mi
        private void addBM(FlowLayoutPanel fpn, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "B" && i is BanhMi bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(bm, Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", bm.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = bm.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_nutmua = false;
                    }
                    else if (fpn.Name == "fpn_sp")
                    {
                        KiemTraItemTrongGioHang(Item);
                        Item.muaclick += (s, e) => muaclicked2(s, e, fpn_gh, tongtien);
                        Item.thich += Item_thich;
                    }

                    fpn.Controls.Add(Item);
                }
            }
        }

        private void Item_thich(object sender, EventArgs e)
        {
            item Item = sender as item;
            xulytim(Item);
        }

        private void muaclicked2(object s, EventArgs e, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            item Item = s as item;
            
            itemingiohang it = xulynutmua(Item, tongtien);
            fpn_gh.Controls.Add(it);
            it.xoa += (se, ee) => xoaclick2(se, ee, fpn_gh, tongtien,Item);
            it.tang += (se, ee) => tangsoln2(se, ee, fpn_gh, tongtien);
            it.giam += (se, ee) => giamsoln2(se, ee, fpn_gh, tongtien);
        }

        private void giamsoln2(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulygiamsl(it, tongtien);
        }

        private void tangsoln2(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulytangsl(it, tongtien);
        }

        private void xoaclick2(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien, item Item)
        {
            itemingiohang it = se as itemingiohang;
            xulyxoa(it, fpn_gh, tongtien, Item);
        }



        //----------------------them caphe
        private void addCP(FlowLayoutPanel fpn, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "C" && i is Caphe bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(bm, Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", bm.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = bm.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_nutmua = false;
                    }
                    else if (fpn.Name == "fpn_sp")
                    {
                        KiemTraItemTrongGioHang(Item);
                        Item.muaclick += (s, e) => muaclicked1(s, e, fpn_gh, tongtien);
                        Item.thich += Item_thich1;
                    }

                    fpn.Controls.Add(Item);
                }
            }
        }

        private void Item_thich1(object sender, EventArgs e)
        {
            item Item = sender as item;
            xulytim(Item);
        }

        private void muaclicked1(object s, EventArgs e, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            item Item = s as item;

            itemingiohang it = xulynutmua(Item, tongtien);
            fpn_gh.Controls.Add(it);
            it.xoa += (se, ee) => xoaclick1(se, ee, fpn_gh, tongtien, Item);
            it.tang += (se, ee) => tangsoln1(se, ee, fpn_gh, tongtien);
            it.giam += (se, ee) => giamsoln1(se, ee, fpn_gh, tongtien);
        }

        private void giamsoln1(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulygiamsl(it, tongtien);
        }

        private void tangsoln1(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulytangsl(it, tongtien);
        }

        private void xoaclick1(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien, item Item)
        {
            itemingiohang it = se as itemingiohang;
            xulyxoa(it, fpn_gh, tongtien, Item);
        }



        // -------------------them giai khat

        private void addGK(FlowLayoutPanel fpn, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id[0].ToString() == "G" && i is Giaikhat bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    KiemTraSPYeuThich(bm, Item);
                    try
                    {
                        string path = img.getpathImg("sanpham", bm.img);
                        Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                    }
                    catch { MessageBox.Show("loi ngap mom"); }
                    if (i.sale != 0)
                    {
                        Item.AA_banggiamgia = true;
                        Item.AA_giamgia = bm.sale.ToString();
                    }
                    if (fpn.Name == "fpn_home")
                    {
                        Item.AA_nutmua = false;
                    }
                    else if (fpn.Name == "fpn_sp")
                    {
                        KiemTraItemTrongGioHang(Item);
                        Item.muaclick += (s, e) => muaclicked3(s, e, fpn_gh, tongtien);
                        Item.thich += Item_thich2;
                    }

                    fpn.Controls.Add(Item);
                }
            }
        }

        private void Item_thich2(object sender, EventArgs e)
        {
            item Item = sender as item;
            xulytim(Item);
        }

        private void muaclicked3(object s, EventArgs e, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            item Item = s as item;

            itemingiohang it = xulynutmua(Item, tongtien);
            fpn_gh.Controls.Add(it);
            it.xoa += (se, ee) => xoaclick3(se, ee, fpn_gh, tongtien, Item);
            it.tang += (se, ee) => tangsoln3(se, ee, fpn_gh, tongtien);
            it.giam += (se, ee) => giamsoln3(se, ee, fpn_gh, tongtien);
        }

        private void giamsoln3(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulygiamsl(it, tongtien);
        }

        private void tangsoln3(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            itemingiohang it = se as itemingiohang;
            xulytangsl(it, tongtien);
        }

        private void xoaclick3(object se, EventArgs ee, FlowLayoutPanel fpn_gh, Label tongtien, item Item)
        {
            itemingiohang it = se as itemingiohang;
            xulyxoa(it, fpn_gh, tongtien, Item);
        }



        //------------------------- them tat ca


        private void addTC(FlowLayoutPanel fpn, FlowLayoutPanel fpn_gh, Label tongtien)
        {
            addBM(fpn, fpn_gh, tongtien);
            addCP(fpn, fpn_gh, tongtien);
            addGK(fpn, fpn_gh, tongtien);
        }




        //--------------------------------------------------------------------------------------



        public void Load(FlowLayoutPanel fpn)
        {
            foreach (var yt in listyt.yt)
            {
                if (yt.Iduse == tkon.Tkc)
                {
                    switch (yt.Masp[0])
                    {
                        case 'B':
                            {
                                addbm(fpn, yt.Masp);
                                break;
                            }
                        case 'C':
                            {
                                addcp(fpn, yt.Masp);
                                break;
                            }
                        case 'G':
                            {
                                addgk(fpn, yt.Masp);
                                break;
                            }
                    }
                }
            }
        }

        private bool KiemTraSPYeuThich(sanpham sp ,item it)
        {
            foreach (var yt in listyt.yt)
            {
                if (tkon.Tkc == yt.Iduse)
                {
                    if(sp.id == yt.Masp)
                    {
                        it.AA_anhtim = Properties.Resources.likedo;
                        it.AA_thich = yt.Chiso;
                        return true;
                    }
                }
            }
            return false;
        }
        private void addbm(FlowLayoutPanel fpn, string masp)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id == masp && i is BanhMi bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    if (KiemTraSPYeuThich(bm, Item))
                    {
                        try
                        {
                            string path = img.getpathImg("sanpham", bm.img);
                            Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                        }
                        catch { MessageBox.Show("loi ngap mom"); }
                        if (i.sale != 0)
                        {
                            Item.AA_banggiamgia = true;
                            Item.AA_giamgia = bm.sale.ToString();
                        }
                        Item.thich += (s, e) => timclickbm(s, e, fpn);
                        Item.muaclick += Item_muaclick;

                        fpn.Controls.Add(Item);
                    }
                }
            }
        }

        private void Item_muaclick(object sender, EventArgs e)
        {
            item Item = sender as item;
            MuaTrongYeuThich(Item);
        }

        private void timclickbm(object s, EventArgs e, FlowLayoutPanel fpn)
        {
            item Item = s as item;
            xoatim(fpn, Item);
        }



        // ------------ them caphe
        private void addcp(FlowLayoutPanel fpn, string masp)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id == masp && i is Caphe bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    if (KiemTraSPYeuThich(bm, Item))
                    {
                        try
                        {
                            string path = img.getpathImg("sanpham", bm.img);
                            Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                        }
                        catch { MessageBox.Show("loi ngap mom"); }
                        if (i.sale != 0)
                        {
                            Item.AA_banggiamgia = true;
                            Item.AA_giamgia = bm.sale.ToString();
                        }
                        Item.thich += (s, e) => timclickcp(s, e, fpn);
                        Item.muaclick += Item_muaclick1;

                        fpn.Controls.Add(Item);
                    }
                }
            }
        }

        private void timclickcp(object s, EventArgs e, FlowLayoutPanel fpn)
        {
            item Item = s as item;
            xoatim(fpn, Item);
        }

        private void Item_muaclick1(object sender, EventArgs e)
        {
            item Item = sender as item;
            MuaTrongYeuThich(Item);
        }




        //------------------them giai khat
        private void addgk(FlowLayoutPanel fpn, string masp)
        {
            foreach (sanpham i in listsp.sanphams)
            {
                if (i.id == masp && i is Giaikhat bm)
                {
                    item Item = new item()
                    {
                        AA_txtdaban = NN.nn[84],
                        AA_txtdanhgia = NN.nn[32],
                        AA_masp = bm.id,
                        AA_tensp = bm.ten,
                        AA_daban = bm.daban.ToString(),
                        AA_danhgia = bm.danhgia.ToString(),
                        AA_bg = ColorTranslator.FromHtml(THEME.t[9]),
                        AA_Gia = bm.giacuoi.ToString()
                    };
                    if (KiemTraSPYeuThich(bm, Item))
                    {
                        try
                        {
                            string path = img.getpathImg("sanpham", bm.img);
                            Item.AA_anhsp = img.LoadImageWithoutLocking(path);
                        }
                        catch { MessageBox.Show("loi ngap mom"); }
                        if (i.sale != 0)
                        {
                            Item.AA_banggiamgia = true;
                            Item.AA_giamgia = bm.sale.ToString();
                        }
                        Item.thich += (s, e) => timclickgk(s, e, fpn);
                        Item.muaclick += Item_muaclick2;

                        fpn.Controls.Add(Item);
                    }
                }
            }
        }

        private void Item_muaclick2(object sender, EventArgs e)
        {
            item Item = sender as item;
            MuaTrongYeuThich(Item);
        }

        private void timclickgk(object s, EventArgs e, FlowLayoutPanel fpn)
        {
            item Item = s as item;
            xoatim(fpn, Item);
        }
    }   
}
