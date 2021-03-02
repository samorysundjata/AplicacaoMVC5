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

        #endregion Public Methods

    }
}