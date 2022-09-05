using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RajDeepSinghApi.Models;

namespace RajDeepSinghApi.Controllers
{
    public class RechargeController : ApiController
    {
        [HttpGet]
        public List<RechargeModel> GetAllRechargeFunc()
        {
            return RechargeModel.GetAllRecharge();
        }
        [HttpGet]
        
        public RechargeModel GetRecharge(int id)
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

