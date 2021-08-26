using AplicacaoMVC5.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AplicacaoMVC5.Data
{
    public class AppDbContext : DbContext
    {
        #region Public Constructors

        public AppDbContext() : base("DefaultConnection")
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public DbSet<Aluno> Alunos { get; set; }

        #endregion Public Properties

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Aluno>().ToTable("Alunos");

            base.OnModelCreating(modelBuilder);
        }
    }
}