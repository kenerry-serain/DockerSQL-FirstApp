using DockerSQLInfrastructure.IoC.Manager;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerSQL.Application.WebAPI.Extensions
{
    /// <summary>
    /// Extensão para injetar os serviços da aplicação
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registrando todos os serviços da aplicação
        /// </summary>
        /// <param name="serviceCollection"></param>
        /// <param name="configuration"></param>
        public static void AddNativeIoC(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            RegisterAllServices(serviceCollection, configuration);
        }

        private static void RegisterAllServices(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            Bootstrapper.RegisterServices(serviceCollection, configuration);
        }
    }
}
