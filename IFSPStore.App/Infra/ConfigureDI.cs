using AutoMapper;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Repository.Repository;
using ConsultorioIFSPContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Service.Service;
using ConsultorioIFSP.App.Models;
using ConsultorioIFSP.App.Cadastros;
using ConsultorioIFSP.App.Outros;


namespace ConsultorioIFSP.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureService()
        {
            var dbConfigFile = "Base/Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                });

            services.AddScoped<IBaseRepository<Medico>, BaseRepository<Medico>>();
            services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();
            services.AddScoped<IBaseRepository<Medicamento>, BaseRepository<Medicamento>>();
            services.AddScoped<IBaseRepository<Receita>, BaseRepository<Receita>>();

            services.AddScoped<IBaseService<Medico>, BaseService<Medico>>();
            services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();
            services.AddScoped<IBaseService<Medicamento>, BaseService<Medicamento>>();
            services.AddScoped<IBaseService<Receita>, BaseService<Receita>>();

            services.AddTransient<Login, Login>();
            services.AddTransient<ReceitaForm, ReceitaForm>();
            services.AddTransient<MedicoForm, MedicoForm>();
            services.AddTransient<MedicamentoForm, MedicamentoForm>();
            services.AddTransient<PacienteForm, PacienteForm>();

            services.AddSingleton(
                new MapperConfiguration(config => {

                    config.CreateMap<Medico, MedicoModel>();
                    config.CreateMap<Paciente, PacienteModel>();
                    config.CreateMap<Medicamento, MedicamentoModel>();
                    config.CreateMap<Receita, ReceitaModel>();
                    config.CreateMap<Consulta, ConsultaModel>();

                    config.CreateMap<Medico, Medico>();
                    config.CreateMap<Paciente, Paciente>();
                    config.CreateMap<Medicamento, Medicamento>();
                    config.CreateMap<Receita, Receita>();
                    config.CreateMap<Consulta, Consulta>();
                },
                NullLoggerFactory.Instance).CreateMapper());
            serviceProvider = services.BuildServiceProvider();
        }
    }
}