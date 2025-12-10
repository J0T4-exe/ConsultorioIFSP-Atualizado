using AutoMapper;
using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSP.Domain.Entities;
using ConsultorioIFSP.Domain.Validators;
using ConsultorioIFSP.Repository.Mapping;
using ConsultorioIFSP.Service.Service;
using ConsultorioIFSPContext;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace ConsultorioIFSP.Test
{
    [TestClass]
    public class ServiceTest
    {
        private ServiceCollection services;

        public ServiceProvider ConfigureService()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>();
            services.AddScoped<IBaseRepository<Medico>, IBaseRepository<Medico>>();
            services.AddScoped<IBaseService<Medico>, BaseService<Medico>>();
            services.AddSingleton(
                new MapperConfiguration (config => { config.CreateMap<Medico, Medico>(); }, 
                NullLoggerFactory.Instance).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        void TestUserService()
        {
            var serviceProvider = ConfigureService();
            var _medicoService = serviceProvider.GetService<IBaseService<Medico>>();
            var medico = new Medico
            {
                Nome = "murilo",
                Password = "123"
            };
            var result = _medicoService.Add<Medico, Medico, MedicoValidator>(medico);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
