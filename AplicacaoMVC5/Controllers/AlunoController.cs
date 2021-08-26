using AplicacaoMVC5.Data;
using AplicacaoMVC5.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace AplicacaoMVC5.Controllers
{
    public class AlunoController : Controller
    {
        #region Private Fields

        private readonly AppDbContext context = new AppDbContext();

        #endregion Private Fields

        #region Public Methods

        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid) return View(aluno);

            aluno.DataMatricula = DateTime.Now;

            context.Alunos.Add(aluno);
            context.SaveChanges();

            return View(aluno);
        }

        [HttpGet]
        [Route("obter-alunos")]
        public ActionResult ObterAlunos()
        {
            var alunos = context.Alunos.ToList();

            return View("Novo Aluno", alunos.FirstOrDefault());
        }

        [HttpGet]
        [Route("editar-aluno")]
        public ActionResult EditarAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "Darth Maul");

            aluno.Nome = "Lord Tyranus";
            var entry = context.Entry(aluno);
            context.Set<Aluno>().Attach(aluno);
            entry.State = EntityState.Modified;

            context.SaveChanges();

            var alunonovo = context.Alunos.Find(aluno.Id);

            return View("Novo Aluno", alunonovo);
        }

        [HttpGet]
        [Route("excluir-aluno")]
        public ActionResult ExcluirAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "Lord Tyranus");

            context.Alunos.Remove(aluno);
            context.SaveChanges();

            var alunos = context.Alunos.ToList();

            return View("Novo Aluno", alunos.FirstOrDefault());
        }


        #endregion Public Methods         
    }
}