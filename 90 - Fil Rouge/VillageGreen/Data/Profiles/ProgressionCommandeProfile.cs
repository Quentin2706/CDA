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
    class ProgressionCommandeProfile : Profile
    {
        public ProgressionCommandeProfile()
        {
        CreateMap<ProgressionCommande, ProgressionCommandeDTOIn>();
        CreateMap<ProgressionCommandeDTOIn, ProgressionCommande>();
        CreateMap<ProgressionCommande, ProgressionCommandeDTOOut>()
            .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
            .ForMember(d => d.LibelleEtatCommande, o => o.MapFrom(s => s.EtatCommande.LibelleEtatCommande));
            CreateMap<ProgressionCommandeDTOOut, ProgressionCommande>();
        }
    }
}
