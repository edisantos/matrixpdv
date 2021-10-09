using lemosinfotec.matrixerp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lemosinfotec.matrixErp.Data.DataConfig
{
    public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Data)
                .IsRequired();

            builder.Property(c => c.ClienteNome)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(c => c.Endereco)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();

            builder.Property(c => c.Numero)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(c => c.Bairro)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();

            builder.Property(c => c.Cidade)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();

            builder.Property(c => c.Estado)
              .HasMaxLength(2)
              .HasColumnType("varchar")
              .IsRequired();

            builder.Property(c => c.Telefone)
              .HasMaxLength(50)
              .HasColumnType("varchar")
              .IsRequired();
        }
    }
}
