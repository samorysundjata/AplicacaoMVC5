using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    [RoutePrefix("testes")]
    public class TesteController : Controller
    {
        [Route("{id2:int}")]
        public ActionResult IndexTeste(int id2, string texto)
        {
            return View();
        }

        [Route("{texto:maxlength(50)}/um-outro-teste/{id2:int}")]
        public ActionResult IndexTeste2(int id2, string texto)
        {
            return View("IndexTeste");
        }
    }
}