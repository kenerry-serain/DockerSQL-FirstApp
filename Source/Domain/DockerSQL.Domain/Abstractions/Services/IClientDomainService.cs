using DockerSQL.Domain.Models;
using System.Threading.Tasks;

namespace DockerSQL.Domain.Abstractions.Services
{
    public interface IClientDomainService
    {
        Task<Client> GetByIdAsync(int clientId);

        Task<Client> AddAsync(Client client);
        Task<Client> UpdateAsync(int clientId, Client client);
        Task DeleteAsync(Client client);
    }
}
