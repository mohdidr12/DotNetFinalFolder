using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_Assessment_7_Asp.net_Mvc.Models;

namespace Code_Assessment_7_Asp.net_Mvc.CustomFilter
{
    public class CustomExceptionHandlerFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is NotImplementedException)
            {
                
            }
            else { }
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            filterContext.ExceptionHandled = true;
        }
    }
}