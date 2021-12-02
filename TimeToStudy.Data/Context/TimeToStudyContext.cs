using Microsoft.EntityFrameworkCore;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Data.Context
{
    public class TimeToStudyContext : DbContext
    {
        public DbSet<AgendaDeEstudo> AgendasDeEstudos { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<SessaoDeEstudo> SessoesDeEstudos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public TimeToStudyContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public TimeToStudyContext(DbContextOptions<TimeToStudyContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}
