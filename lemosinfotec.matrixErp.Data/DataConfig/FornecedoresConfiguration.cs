using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class FornecedoresConfiguration : IEntityTypeConfiguration<Fornecedores>
    {
        public void Configure(EntityTypeBuilder<Fornecedores> builder)
        {
            builder.ToTable("Fornecedores");

            builder.HasKey(f => f.FornecedorId);

            builder.Property(f => f.FornecedorNome)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(f => f.Cnpj)
                .HasMaxLength(11)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(f => f.Endereco)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(f => f.Cidade)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(f => f.Estado)
                .HasMaxLength(2)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(f => f.Telefone)
                .HasMaxLength(20)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
