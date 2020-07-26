using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TodoApp.Dominio.Entidades;
using TodoApp.Infra.Contexts.Mapeamentos;

namespace TodoApp.Infra.Contexts
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _config;

        public DataContext(DbContextOptions<DataContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaBDMapeamento());
            //base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("connCurso"));
        }
    }
}
