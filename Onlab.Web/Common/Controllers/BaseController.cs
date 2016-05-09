using Onlab.Web.Framework.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onlab.Web.Common.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult Render(object model)
        {
            //if (Request.Headers.AllKeys.Any(k => k == "Request-Type"))
            if (true)
            {
                return Json(ModelTranslator.Translate(model), JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View(model);
            }
        }

    }
}