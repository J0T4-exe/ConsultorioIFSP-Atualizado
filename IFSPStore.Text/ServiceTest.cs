using AutoMapper;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Service.Service;
using IFSPStore.Service.Validator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace IFSPStore.Test
{
    [TestClass]
    public class ServiceTest
    {
        private ServiceCollection services;

        public ServiceProvider ConfigureService()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>();
            services.AddScoped<IBaseRepository<User>, IBaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration (config => { config.CreateMap<User, User>(); }, 
                NullLoggerFactory.Instance).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        void TestUserService()
        {
            var serviceProvider = ConfigureService();
            var _userService = serviceProvider.GetService<IBaseService<User>>();
            var user = new User
            {
                Name = "murilo",
                Password = "123"
            };
            var result = _userService.Add<User, User, UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
