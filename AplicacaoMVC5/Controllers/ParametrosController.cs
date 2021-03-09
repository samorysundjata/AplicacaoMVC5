using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    public class ParametrosController : Controller
    {
        // GET: Parametros
        public ActionResult Index(int id1)
        {
            return View();
        }
    }
}