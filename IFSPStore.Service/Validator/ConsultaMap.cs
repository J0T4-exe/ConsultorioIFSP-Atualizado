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


            /*builder.HasOne(c => c.Paciente) // Uma Consulta tem Um Paciente
                   .WithMany() // O Paciente pode ter Muitas Consultas
                   .HasForeignKey(c => c.PacienteId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            // Relação com Medico
            builder.HasOne(c => c.Medico) // Uma Consulta tem Um Médico
                   .WithMany() // O Médico pode ter Muitas Consultas
                   .HasForeignKey(c => c.MedicoId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);

            //Uma restrição para garantir que um médico só possa ter uma consulta com um paciente em um horário específico.
            builder.HasIndex(c => new { c.MedicoId, c.DataConsulta, c.Horario })
                   .IsUnique();*/
        }
    }
}