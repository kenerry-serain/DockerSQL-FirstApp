using DockerSQL.Application.InOut.Clients;
using System.Threading.Tasks;

namespace DockerSQL.Application.Abstractions
{
    public interface IClientApplicationService
    {
        Task<ClientResponse> GetByIdAsync(int clientId);
        Task<ClientResponse> AddAsync(ClientRequest client);
        Task<ClientResponse> UpdateAsync(int clientId, ClientRequest client);
        Task DeleteAsync(int clientId);
    }
}
