using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers.Filters
{
    public class CustomExceptionAttribute:FilterAttribute,IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.OnException = "IExceptionFilter.OnException filter called";
        }
    }
    
}