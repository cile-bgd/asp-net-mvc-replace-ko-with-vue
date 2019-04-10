using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Vue.Controllers
{
    public class ProvinceLookupController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Provinces(string countryCode)
        {
            var provinces = GetProvinces(countryCode);
            return Json(provinces);
        }

        private List<string> GetProvinces(string countryCode)
        {
            var list = new List<string>();

            if (countryCode == "us")
            {
                list.Add("Arizona");
                list.Add("Alaska");
                list.Add("New Jersey");
            }
            else
            {
                list.Add("Ontario");
                list.Add("Quebec");
                list.Add("Alberta");
            }

            return list;
        }
    }
}
