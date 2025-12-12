using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultorioIFSP.Repository.Mapping
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            // CORREÇÃO 1: Usar nome minúsculo no ToTable para evitar problemas de case-sensitivity no MySQL.
            builder.ToTable("receita");
            builder.HasKey(prop => prop.Id);

            // Periodo
            builder.Property(prop => prop.Periodo)
                .IsRequired()
                // CORREÇÃO 2: Usar tipo compatível com MySQL/MariaDB
                .HasColumnType("datetime");

            // Quantidade
            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            // Relacionamento com Medico
            builder.HasOne<Medico>()
                .WithMany()
                .HasForeignKey(receita => receita.MedicoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento com Paciente
            builder.HasOne<Paciente>()
                .WithMany()
                .HasForeignKey(receita => receita.PacienteId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}