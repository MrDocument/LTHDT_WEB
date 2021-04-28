using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Entities
{
    public class TAMGIAC
    {
        //thanh phan du lieu
        private DIEM A;
        private DIEM B;
        private DIEM C;

        //thanh phan xu ly
        public TAMGIAC(DIEM a, DIEM b, DIEM c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double TinhChuVi()
        {
            double a, b, c;
            a = this.B.KhoangCach2Diem(C);
            b = this.C.KhoangCach2Diem(A);
            c = this.A.KhoangCach2Diem(B);
            return a + b + c;
        }
    }
}