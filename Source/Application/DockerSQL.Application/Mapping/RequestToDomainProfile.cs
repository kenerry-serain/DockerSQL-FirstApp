using AutoMapper;
using DockerSQL.Application.InOut.Clients;
using DockerSQL.Domain.Models;

namespace DockerSQL.Application.Mapping
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<ClientRequest, Client>()
                .ForMember(client => client.Id, configuration => configuration.Ignore())
                .ConstructUsing(client => new Client(client.Name, client.Email));
        }
    }
}
