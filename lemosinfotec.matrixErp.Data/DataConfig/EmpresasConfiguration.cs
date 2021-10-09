using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class EmpresasConfiguration : IEntityTypeConfiguration<Empresas>
    {
        public void Configure(EntityTypeBuilder<Empresas> builder)
        {
            builder.ToTable("Empresas");
            builder.HasKey(e => e.EmpresaId);

            builder.Property(e => e.EmpresaNome)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            
        }
    }
}
