using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("AllRecharge")]
        public List<RechargeModel> Abc()
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
        public string Delete(int id)
        {
            return "Delete Success";
        }
    }
}
