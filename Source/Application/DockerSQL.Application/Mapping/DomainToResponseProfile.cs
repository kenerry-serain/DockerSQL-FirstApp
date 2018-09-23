using AutoMapper;
using DockerSQL.Application.InOut.Clients;
using DockerSQL.Domain.Models;

namespace DockerSQL.Application.Mapping
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Client, ClientResponse>();
        }
    }
}
