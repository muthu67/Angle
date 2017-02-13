using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angle.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("~/Views/Master/Person/Person.cshtml");
        }

        public JsonResult GetPesrons()
        {

            Model1 e = new Model1();
            var result = e.EmployeePassports.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}
