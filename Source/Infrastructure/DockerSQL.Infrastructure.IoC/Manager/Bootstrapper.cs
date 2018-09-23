using DockerSQL.Application.Abstractions;
using DockerSQL.Application.Implementations;
using DockerSQL.Domain.Abstractions.Repositories;
using DockerSQL.Domain.Abstractions.Services;
using DockerSQL.Domain.Implementations.Services;
using DockerSQL.Infrastructure.Repository.Context;
using DockerSQL.Infrastructure.Repository.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DockerSQLInfrastructure.IoC.Manager
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IClientApplicationService, ClientApplicationService>();
            serviceCollection.AddScoped<IClientDomainService, ClientDomainService>();
            serviceCollection.AddScoped<IClientRepository, ClientRepository>();

            serviceCollection.AddSingleton(sp => new ClientManagementContext(configuration.GetConnectionString("Default")));
        }
    }
}
