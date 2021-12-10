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
    class EtatCommandeProfile : Profile
    {
        public EtatCommandeProfile()
        {
            CreateMap<EtatCommande, EtatCommandeDTOIn>();
            CreateMap<EtatCommandeDTOIn, EtatCommande>();
            CreateMap<EtatCommande, EtatCommandeDTOOut>();
            CreateMap<EtatCommandeDTOOut, EtatCommande>();
        }
    }
}
