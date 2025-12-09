using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Repository.Mapping;
using Microsoft.EntityFrameworkCore;


namespace ConsultorioIFSPContext
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext>? op = null) : base(op)
        {
            Database.EnsureCreated();//cria o banco de dados
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ConsultorioIFSP;user=root;password=");
        }
        public DbSet<Medico> Medicos { get; set; }//cada classe vira uma tabela
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Medico>(new MedicoMap().Configure);
            modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            modelBuilder.Entity<Medicamento>(new MedicamentoMap().Configure);
            modelBuilder.Entity<Receita>(new ReceitaMap().Configure);
        }

    }
}


