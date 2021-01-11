using AplicacaoMVC5.Models;
using System;
using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    public class AlunoController : Controller
    {
        #region Public Methods

        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            return View(aluno);
        }

        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno
            {
                Id = 1,
                Nome = "Joseh das Couves",
                CPF = "0126468780-98",
                DataMatricula = DateTime.Now,
                Email = "jose@couves.com",
                Ativo = true
            };

            return RedirectToAction("Index", aluno);
        }

        #endregion Public Methods
    }
}