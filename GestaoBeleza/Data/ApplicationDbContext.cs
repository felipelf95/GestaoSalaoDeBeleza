
using GestaoBeleza.Models;
using GestaoBeleza.Models.Cliente;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoBeleza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<InformacaoTecnica> InformacaoTecnica { get; set; }
        public DbSet<HistoricoQuimico> HistoricoQuimico { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
