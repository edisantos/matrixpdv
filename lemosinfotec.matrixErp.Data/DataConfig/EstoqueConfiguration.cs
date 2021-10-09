using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("Estoque");

            builder.HasKey(e => e.EstoqueId);

            builder.Property(e => e.DataRegistro)
                   .IsRequired();

            builder.Property(e => e.ProdutoId)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(e => e.Quantidade)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(e => e.EstoqueMin)
                .HasColumnType("int")
                .IsRequired();

          

        }
    }
}
