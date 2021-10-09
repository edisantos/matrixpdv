using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class ParceirosConfiguration : IEntityTypeConfiguration<Parceiros>
    {
        public void Configure(EntityTypeBuilder<Parceiros> builder)
        {
            builder.ToTable("Parceiros");

            builder.HasKey(p => p.ParceiroId);

            builder.Property(p => p.DataCadastro)
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(p => p.Endereceo)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(p => p.Numero)
                .HasMaxLength(50)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Bairro)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(p => p.Estado)
                .HasMaxLength(2)
                .HasColumnType("varchar")
                .IsRequired();

           

        }
    }
}
