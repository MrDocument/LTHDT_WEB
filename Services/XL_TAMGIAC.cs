using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTHDT_WEB.Entities;

namespace LTHDT_WEB.Services
{
    public class XL_TAMGIAC
    {
        public ServiceResult<double> TinhChuVi(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            ServiceResult<double> result = new ServiceResult<double>();
            var A = new DIEM(x1, y1);
            var B = new DIEM(x2, y2);
            var C = new DIEM(x3, y3);
            
            if (KiemTraTinhHopLe(A, B, C) == false)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Tam giac khong hop le";

                return result;
            }
            
            TAMGIAC tg = new TAMGIAC(A, B, C);
            var chuvi = tg.TinhChuVi();

            result.Data = chuvi;
            result.IsSuccess = true;

            return result;
        }

        public bool KiemTraTinhHopLe(DIEM A, DIEM B, DIEM C)
        {
            double a, b, c;
            a = B.KhoangCach2Diem(C);
            b = C.KhoangCach2Diem(A);
            c = A.KhoangCach2Diem(B);

            return a + b > c && a + c > b && b + c > a; 
        }
    }
}