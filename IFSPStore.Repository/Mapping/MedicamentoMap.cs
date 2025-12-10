using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultorioIFSP.Repository.Mapping
{
    public class MedicamentoMap : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.ToTable("Medicamento");
            builder.HasKey(prop => prop.Id); // Id da BaseEntity

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(100);

            builder.Property(prop => prop.Nome_Generico)
                .IsRequired()
                .HasColumnName("Nome_Generico")
                .HasMaxLength(100);
        }
    }
}