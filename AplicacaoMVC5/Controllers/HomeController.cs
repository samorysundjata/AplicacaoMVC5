using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    public class HomeController : Controller
    {
        #region Public Methods

        public ActionResult Index()
        {
            return View();
        }

        [Route("sobre-nos")]
        public ActionResult About()
        {
            return View();
        }
        
        [Route("institucional/entre-contato")]
        public ActionResult Contact()
        {
            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("Olá");
        }

        public FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.jpg"));

            return File(foto, "image/png", "capa.png");
        }

        public HttpUnauthorizedResult HttpUnauthorizedResult()
        {
            return new HttpUnauthorizedResult();
        }

        //public ViewResult Index()
        //{
        //    return View();
        //}

        public JsonResult JsonResult()
        {
            return Json("teste:'Teste'", JsonRequestBehavior.AllowGet);
        }

        public RedirectResult RedirectResult()
        {
            return new RedirectResult("https://samory.sistemasresponsivos.com.br");
        }

        public RedirectToRouteResult RedirectToRouteResult()
        {
            return RedirectToRoute(new
            {
                controller = "Home",
                action = "Index"
            });

            //return RedirectionToAction("Index");
        }

        #endregion Public Methods
    }
}