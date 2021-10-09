using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    class ProdutosConfiguration : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.ToTable("Produtos");

            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.ProdutoNome)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
