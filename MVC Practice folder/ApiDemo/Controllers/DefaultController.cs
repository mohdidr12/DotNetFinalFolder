using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApiDemo.Models;
using System.Web.Http;

namespace ApiDemo.Controllers
{
    public class DefaultController : ApiController
    {
     
       public List<RechargeModel> AllRecharge()
        {
            return RechargeModel.GetAllRecharge();
        }
        [HttpGet]
        [Route("GetRecharge")]
        public RechargeModel Xyz(int id)
        {
            return RechargeModel.GetAllRecharge().FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        [Route("InsertRecharge")]
        public string InsertRecharge(RechargeModel rm)
        {
            if (rm != null)
            {
                return "recharge Success";
            }
            else
                return "Recharge Not Success";
        }
        [HttpDelete]
        public string Delete(int id )
        {
            return "Delete Success";
        }
    }
}