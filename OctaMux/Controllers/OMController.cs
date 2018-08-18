using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OctaMux.Controllers
{
    public class OMController : Controller
    {
        // GET: OM
        public ActionResult Home()
        {
            return View();
        }
    }
}