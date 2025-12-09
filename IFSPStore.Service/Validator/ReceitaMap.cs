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

            /* builder.HasOne(receita => receita.Medico) // Uma Receita tem Um Medico
                    .WithMany() // O Medico pode ter Muitas Receitas
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict); 

             // Relação com Paciente: Uma Receita pertence a um Paciente
             builder.HasOne(receita => receita.Paciente) // Uma Receita tem Um Paciente
                    .WithMany() // O Paciente pode ter Muitas Receitas 
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Restrict); */
        }
    }
}