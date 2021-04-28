using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Entities
{
    public class SANPHAM
    {
        public int maSp { get; set; }
        public string tenSp { get; set; }
        public int giaSp { get; set; }

        public SANPHAM(int ma, string ten, int gia)
        {
            this.maSp = ma;
            this.tenSp = ten;
            this.giaSp = gia;
        }
        
        
    }
}