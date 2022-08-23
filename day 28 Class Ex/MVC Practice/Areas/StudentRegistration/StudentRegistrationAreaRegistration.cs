using System.Web.Mvc;

namespace MVC_Practice.Areas.StudentRegistration
{
    public class StudentRegistrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StudentRegistration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StudentRegistration_default",
                "StudentRegistration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}