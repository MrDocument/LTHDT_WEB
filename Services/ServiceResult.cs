using LTHDT_WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTHDT_WEB.Services
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        //public PHANSO Data { get; set; }
        public T Data { get; set; }
             
    }
}