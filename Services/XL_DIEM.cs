using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTHDT_WEB.Entities;

namespace LTHDT_WEB.Services
{
    public class XL_DIEM
    {
        public double TinhKhoangCachDiem(int x1, int y1, int x2, int y2)
        {
            var A = new DIEM(x1, y1);
            var B = new DIEM(x2, y2);

            return A.KhoangCach2Diem(B);
        }
    }
}