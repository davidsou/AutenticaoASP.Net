using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutenticaoASP.Net.Controllers
{
    public class PainelController : Controller
    {
        // GET: Painel
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Painel
        [Authorize]
        public ActionResult Mensagens()
        {
            return View();
        }
    }
}