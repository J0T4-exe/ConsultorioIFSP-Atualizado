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

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

            services.AddTransient<Login, Login>();
            services.AddTransient<ReceitaForm, ReceitaForm>();
            services.AddTransient<MedicoForm, MedicoForm>();
            services.AddTransient<MedicamentoForm, MedicamentoForm>();
            services.AddTransient<PacienteForm, PacienteForm>();
            services.AddTransient<ConsultaForm, ConsultaForm>(); 

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