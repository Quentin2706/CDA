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
    class VilleProfile : Profile
    {
        public VilleProfile()
        {
            CreateMap<Ville, VilleDTOIn>();
            CreateMap<VilleDTOIn, Ville>();
            CreateMap<Ville, VilleDTOOut>()
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Pays.NomPays));
            CreateMap<VilleDTOOut, Ville>();
        }
    }
}
