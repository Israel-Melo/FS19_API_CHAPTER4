using Chapter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }

        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) { }
        //vamos utilizar esse método para configura o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                //cada provedir tem sua sintaxe para especificação 
                // Data Source
                // initial catalog
                // integrated security
                // TrustServerCertificate
                // optionsBuilder.UseSqlServer("Data Source = DESKTOP-N5Q5RBB\\SQLEXPRESS; initial catalog = Chapter2; Intergrated Security = true ; TrustServerCertificate = True");
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-N5Q5RBB\\SQLEXPRESS; initial catalog = Chapter2; user id = SA; password = 1234 ; TrustServerCertificate = True");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualiização e deleção
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
