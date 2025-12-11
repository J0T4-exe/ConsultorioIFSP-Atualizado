using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsultorioIFSP.Repository.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");
            builder.HasKey(prop => prop.Id);

            // DataConsulta
            builder.Property(prop => prop.DataConsulta)
                .IsRequired()
                .HasColumnType("date");
            var timeOnlyConverter = new ValueConverter<TimeOnly, TimeSpan>(
                timeOnly => timeOnly.ToTimeSpan(),
                timeSpan => TimeOnly.FromTimeSpan(timeSpan)
            );

            builder.Property(prop => prop.Horario)
                   .HasConversion(timeOnlyConverter) // Aplica o conversor
                   .IsRequired();


            builder.HasOne<Medico>()
                .WithMany()
                .HasForeignKey(receita => receita.MedicoId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            // Relação com Medico
            builder.HasOne<Paciente>()
               .WithMany() 
               .HasForeignKey(receita => receita.PacienteId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

            //Uma restrição para garantir que um médico só possa ter uma consulta com um paciente em um horário específico.
            builder.HasIndex(c => new { c.MedicoId, c.DataConsulta, c.Horario })
                   .IsUnique();
        }
    }
}