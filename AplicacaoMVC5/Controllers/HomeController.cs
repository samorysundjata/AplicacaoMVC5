using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    public class HomeController : Controller
    {
        #region Public Methods

        public ViewResult Index()
        {
            return View();
        }

        public ContentResult ContentResult()
        {
            return Content("Olá");
        }

        public  FileContentResult FileContentResult()
        {
            var foto = System.IO.File.ReadAllBytes(Server.MapPath("/content/images/capa.jpg"));

            return File(foto, "image/png", "capa.png");
        }

        #endregion Public Methods

    }
}