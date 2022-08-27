using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo1.Controllers.Filters
{
    public class CustomResultAttribute : FilterAttribute,IResultFilter
    {
        void   IResultFilter.OnResultExecuted(ResultExecutedContext filterContext)
        {
              filterContext.Controller.ViewBag.OnResultExecuted=("IResultFilter.OnResultExecuted filter Called");
         }
        void IResultFilter.OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnResultExecuting = ("IResultFilter.OnResultExecuting filter Called");
        }
       
      
    }
}