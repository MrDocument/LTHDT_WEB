using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Entities
{
    public class PHANSO
    {
        //thanh phan du lieu
        private int MauSo;


        //thanh phan xu ly
        public PHANSO()
        {
            this.TuSo = 0;
            this.MauSo = 1;
        }
        public PHANSO(int t, int m)
        {
            this.TuSo = t;
            if (m != 0)
            {
                this.MauSo = m;
            }
            else
                this.MauSo = 1;
        }
        public int TuSo { get; set; }

        public int MAU_SO
        {
            get
            {
                return this.MauSo;
            }
            set
            {
                if (value != 0)
                {
                    this.MauSo = value;
                }                
            }
        }
       
        public PHANSO Cong2PhanSo(PHANSO b)
        {
            PHANSO kq =new PHANSO();
            kq.TuSo = this.TuSo * b.MauSo + b.TuSo * this.MauSo;
            kq.MauSo = this.MauSo * b.MauSo;
            return kq;
        }
        public string XuatPhanSo()
        {
            return string.Format($"{this.TuSo}/{this.MauSo}");
        }

    }
}