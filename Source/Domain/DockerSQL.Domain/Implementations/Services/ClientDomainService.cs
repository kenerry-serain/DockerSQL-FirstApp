using DockerSQL.Domain.Abstractions.Repositories;
using DockerSQL.Domain.Abstractions.Services;
using DockerSQL.Domain.Models;
using System.Threading.Tasks;

namespace DockerSQL.Domain.Implementations.Services
{
    public sealed class ClientDomainService : IClientDomainService
    {
        private readonly IClientRepository _entityRepository;
        public ClientDomainService(IClientRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task<Client> GetByIdAsync(int entityId)
        {
            return await _entityRepository.GetByIdAsync(entityId);
        }

        public async Task<Client> AddAsync(Client entity)
        {
            await _entityRepository.AddAsync(entity);
            await _entityRepository.SaveChangesAsync();
            return entity;
        }

        public async Task<Client> UpdateAsync(int entityId, Client entity)
        {
            await _entityRepository.UpdateAsync(entityId, entity);
            await _entityRepository.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(Client entity)
        {
            await _entityRepository.RemoveAsync(entity);
            await _entityRepository.SaveChangesAsync();
        }
    }
}
