using LTHDT_WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Services
{
    public class XL_DAGIAC
    {
        public ServiceResult<DAGIAC> KhoiTao(string chuoiDaGiac)
        {
            var result = new ServiceResult<DAGIAC>();
            string[] M = chuoiDaGiac.Split('|');
            //"(2,3)(3,2)(3,4)"
            if (M.Length <= 2)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "Da giac khong hop le";

                return result;
            }
            DAGIAC dg = new DAGIAC();
            
            foreach (string s in M)
            {
                DIEM a = new DIEM(s);
                dg.dsDinh.Add(a);
            }

            result.IsSuccess = true;
            result.Data = dg;

            return result;
        }

    }
}