using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Entities
{
    public class DAGIAC
    {
        //List<> la 1 generic co san trong thu vien
        public List<DIEM> dsDinh;

        public DAGIAC()
        {
            this.dsDinh = new List<DIEM>();
        }

        public double ChuViDaGiac()
        {
            double ChuVi = 0;
            for (int i = 0; i < this.dsDinh.Count - 1; i++)
            {
                ChuVi = ChuVi + this.dsDinh[i].KhoangCach2Diem(this.dsDinh[i + 1]);
            }
            ChuVi = ChuVi + this.dsDinh[0].KhoangCach2Diem(this.dsDinh[this.dsDinh.Count - 1]);
            return ChuVi;
        }
    }
}