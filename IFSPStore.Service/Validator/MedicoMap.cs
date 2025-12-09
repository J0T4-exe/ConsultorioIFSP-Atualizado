using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultorioIFSP.Repository.Mapping
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");
            builder.HasKey(prop => prop.Id); // Id da BaseEntity

            // Nome
            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(100);

            // Login
            builder.Property(prop => prop.Login)
                .IsRequired()
                .HasMaxLength(50);

            // Password
            builder.Property(prop => prop.Password)
                .IsRequired()
                .HasMaxLength(100);

            // Especialidade
            builder.Property(prop => prop.Especialidade)
                .IsRequired()
                .HasColumnName("Especialidade")
                .HasMaxLength(100);

            // CRM
            builder.Property(prop => prop.Crm)
                .IsRequired()
                .HasColumnName("Crm")
                .HasMaxLength(20);

            // Telefone
            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnName("Telefone")
                .HasMaxLength(20);
        }
    }
}