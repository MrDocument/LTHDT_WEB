using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Entities
{
    public class DIEM
    {
        //Thanh phan du lieu
        public int X;
        public int Y;

        //thanh phan xu ly

        //public int X { get; set; }
        //public int Y { get; set; }
        public DIEM()
        {
            this.X = 0;
            this.Y = 1;
        }
        public DIEM(string s)
        {
            //s="(2,3)(2,3)(3,4)"
            s = s.Substring(1, s.Length - 2);
            //s="2,3"
            string[] M = s.Split(',');
            this.X = int.Parse(M[0]);
            this.Y = int.Parse(M[1]);
        }

        public DIEM(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double KhoangCach2Diem(DIEM b)
        {
            return Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
        }

        public string XuatDiem()
        {
            return string.Format($"{this.X}/{this.Y}");
        }
    }
}