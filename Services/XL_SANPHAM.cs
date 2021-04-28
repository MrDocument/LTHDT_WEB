using LTHDT_WEB.DAL;
using LTHDT_WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace LTHDT_WEB.Services
{
    public class XL_SANPHAM
    {
        public List<SANPHAM> TimSanPham(string keyword)
        {
            var lt = new LT_SANPHAM();
            var dsSanPham = lt.DocDanhSachSanPham();

            List<SANPHAM> ketqua = new List<SANPHAM>();

            foreach (var sp in dsSanPham)
            {
                if (sp.tenSp.Contains(keyword))
                {
                    ketqua.Add(sp);
                }
            }

            return ketqua;
        }
        public List<SANPHAM> XoaSanPham(string keyword)
        {
            var luutru = new LT_SANPHAM();
            var dsSanPham = luutru.DocDanhSachSanPham();
            List<SANPHAM> ketqua = new List<SANPHAM>();
            foreach (var sp in dsSanPham)
            {
                if (sp.tenSp.Contains(keyword))
                {
                    ketqua.Remove(sp);
                }
            }
            luutru.LuuDanhSachSanPham(dsSanPham);
            return ketqua;
        }
        public void ThemSanPham(string ten,int gia)
        {
            var lt = new LT_SANPHAM();
            var dsSanPham = lt.DocDanhSachSanPham();
            int masp = 0;
            for (int i = 0; i < dsSanPham.Count; i++)
            {
                if(masp < dsSanPham[i].maSp)
                {
                    masp = dsSanPham[i].maSp;
                }
            }
            masp++;
            SANPHAM sp = new SANPHAM(masp,ten,gia);

            lt.LuuSanPham(sp);
        }

        public void SuaSanPham(SANPHAM sp)
        {
            var lt = new LT_SANPHAM();
            var dsSanPham = lt.DocDanhSachSanPham();
            for (int i = 0; i < dsSanPham.Count; i++)
            {
                if (dsSanPham[i].maSp == sp.maSp)
                {
                    dsSanPham[i] = sp;
                }
            }
            lt.LuuDanhSachSanPham(dsSanPham);
        }
        public SANPHAM DocSanPham(int masp)
        {
            var lt = new LT_SANPHAM();
            var dsSanPham = lt.DocDanhSachSanPham();
            for (int i = 0; i < dsSanPham.Count; i++)
            {
                if (dsSanPham[i].maSp == masp)
                {
                    return dsSanPham[i];
                }
            }

            return null;
        }
        


    }
}