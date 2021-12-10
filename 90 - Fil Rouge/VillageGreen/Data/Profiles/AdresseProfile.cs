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
    class AdresseProfile : Profile
    {
        public AdresseProfile()
        {
            CreateMap<Adresse, AdresseDTOIn>();
            CreateMap<AdresseDTOIn, Adresse>();
            CreateMap<Adresse, AdresseDTOOut>()
            .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Ville.LibelleVille))
            .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Ville.CodePostal))
            .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Ville.Pays.NomPays));
            CreateMap<AdresseDTOOut, Adresse>();
        }
    }
}
