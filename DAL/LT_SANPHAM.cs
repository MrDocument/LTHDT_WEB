using LTHDT_WEB.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.DAL
{
    public class LT_SANPHAM
    {   
        public List<SANPHAM> DocDanhSachSanPham()
        {
            List<SANPHAM> ds = new List<SANPHAM>();
            StreamReader reader = new StreamReader("D:\\TXT\\dssp.txt");
            //.ReadLine(): Reads a line of characters from the current stream
            //and returns the data as a string.
            string s = reader.ReadLine();
            int N = int.Parse(s);

            for (int i = 0; i < N; i++)
            {
                s = reader.ReadLine();
                string[] M = s.Split(',');
                SANPHAM sp = new SANPHAM(int.Parse(M[0]), M[1], int.Parse(M[2]));

                //.Add : Adds an object to the end of the List<T>.
                ds.Add(sp);
            }
            reader.Close();
            return ds;

        }

        public void LuuDanhSachSanPham(List<SANPHAM> ds)
        {
            StreamWriter writer = new StreamWriter("D:\\TXT\\dssp.txt");
            writer.WriteLine(ds.Count);
            foreach(var sp in ds)
            {
                writer.WriteLine($"{sp.maSp},{sp.tenSp},{sp.giaSp}");
            }
            writer.Close();
        }
        public void LuuSanPham(SANPHAM sp)
        {
            var ds = DocDanhSachSanPham();
            ds.Add(sp);
            LuuDanhSachSanPham(ds);
        }        
    }
}