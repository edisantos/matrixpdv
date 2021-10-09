using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class ContaEmpresasConfiguration : IEntityTypeConfiguration<ContaEmpresas>
    {
        public void Configure(EntityTypeBuilder<ContaEmpresas> builder)
        {
            builder.ToTable("ContaEmpresas");

            builder.HasKey(e => e.ContaEmpresaId);

               builder.Property(e => e.DataVencimento)
                .IsRequired();

            builder.Property(e => e.StatusPagamento)
                .HasColumnType("varchar")
                .HasMaxLength(10)
               .IsRequired();

            builder.Property(e => e.Ativo)
             .IsRequired();

        }
    }
}
