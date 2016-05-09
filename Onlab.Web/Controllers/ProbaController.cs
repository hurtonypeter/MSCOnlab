using Onlab.Web.Common.Controllers;
using Onlab.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onlab.Web.Controllers
{
    public class ProbaController : BaseController
    {
        public ActionResult Index()
        {
            return Render(new ProbaModel
            {
                Id = 1,
                Name = "textboxszöveg"
            });
        }

    }
}