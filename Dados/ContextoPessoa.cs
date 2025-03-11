using CrudPessoa.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoa.Dados
{
    public class ContextoPessoa : DbContext
    {
        public DbSet<ModeloPessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=CrudPessoa.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
