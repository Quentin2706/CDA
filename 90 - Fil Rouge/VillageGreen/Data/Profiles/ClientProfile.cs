using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;
using VillageGreen.Data.Dtos;

namespace VillageGreen.Data.Profiles
{
    class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTOIn>();
            CreateMap<ClientDTOIn, Client>();
            CreateMap<Client, ClientDTOOut>()
            .ForMember(d => d.LibelleCategClient, o => o.MapFrom(s => s.CategorieClient.LibelleCategClient));
            CreateMap<ClientDTOOut, Client>();
        }
    }
}
