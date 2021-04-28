using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LTHDT_WEB.Entities;

namespace LTHDT_WEB.Services
{
    public class XL_PHANSO
    {
        public ServiceResult<PHANSO> TinhTong2PhanSo(int x1, int y1, int x2, int y2)
        {
            ServiceResult<PHANSO> result = new ServiceResult<PHANSO>();
            if(y1 == 0 || y2 == 0)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Mau so phai khac khong";

                return result;
            }


            var p1 = new PHANSO(x1, y1);
            var p2 = new PHANSO(x2, y2);

            var s = p1.Cong2PhanSo(p2);

            result.IsSuccess = true;
            result.Data = s;

            return result;
        }
    }
}