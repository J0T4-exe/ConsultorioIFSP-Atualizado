using ConsultorioIFSP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ConsultorioIFSP.Repository.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Nome)
                .HasConversion(prop => prop!.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Nome")
                .HasMaxLength(100);
            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.DataNascimento)
                .HasDefaultValue(DateTime.Now);
            builder.Property(prop => prop.Telefone)
                .IsRequired() // Assumindo que o telefone é obrigatório
                .HasColumnName("Telefone");
            builder.Property(prop => prop.Sexo)
                .IsRequired()
                .HasColumnName("Sexo")
                .HasMaxLength(10);
            /* builder.Property(prop => prop.LoginDate)
                 .IsRequired()
                 .HasMaxLength(100);*/
            //builder.Property(prop => prop.IsActive);
        }
    }
}



