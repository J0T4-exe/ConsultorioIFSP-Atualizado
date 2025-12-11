using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsultorioIFSP.Repository.Mapping
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("Receita");
            builder.HasKey(prop => prop.Id);

            // Periodo
            builder.Property(prop => prop.Periodo)
                .IsRequired()
                .HasColumnType("datetime2");

            // Quantidade
            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.HasOne<Medico>()
                .WithMany()   
                .HasForeignKey(receita => receita.MedicoId) 
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Paciente>() // Configura o relacionamento com a Entidade Paciente
               .WithMany()         // O Paciente pode ter muitas Receitas
               .HasForeignKey(receita => receita.PacienteId) // Define qual campo INT é a FK
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}