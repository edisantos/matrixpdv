using lemosinfotec.matrixerp.Domain.Entities;
using lemosinfotec.matrixErp.Data.DataConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lemosinfotec.matrixErp.Data.Contexto
{
    public class DataContexto:IdentityDbContext<User>
    {
        public DbSet<User> User { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Parceiros> Parceiros { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empresas> Empresas { get; set; }
        public DbSet<ContaEmpresas> ContaEmpresas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string strConnection = string.Format(@"*************");
            optionsBuilder.UseSqlServer(strConnection);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Estoque>(new EstoqueConfiguration().Configure);
            builder.Entity<Produtos>(new ProdutosConfiguration().Configure);
            builder.Entity<Usuarios>(new UsuariosConfiguration().Configure);
            builder.Entity<Parceiros>(new ParceirosConfiguration().Configure);
            builder.Entity<Clientes>(new ClientesConfiguration().Configure);
            builder.Entity<Empresas>(new EmpresasConfiguration().Configure);
            builder.Entity<ContaEmpresas>(new ContaEmpresasConfiguration().Configure);
            builder.Entity<Fornecedores>(new FornecedoresConfiguration().Configure);

            builder.Entity<Estoque>()
                .HasMany(f => f.Fornecedores)
                .WithOne(e => e.Estoque);

            builder.Entity<Estoque>()
                .HasMany(f => f.Produtos)
                .WithOne(e => e.Estoque);

            builder.Entity<Empresas>()
                .HasOne(p => p.Parceiros)
                .WithMany(p => p.Empresas);

            base.OnModelCreating(builder);
        }
    }
}
