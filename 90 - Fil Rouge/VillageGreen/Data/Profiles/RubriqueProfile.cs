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
    class RubriqueProfile : Profile
    {
        public RubriqueProfile()
        {
            CreateMap<Rubrique, RubriqueDTOIn>();
            CreateMap<RubriqueDTOIn, Rubrique>();
            CreateMap<Rubrique, RubriqueRubriqueMereDTOOut>()
                .ForMember(d => d.LibelleRubriqueMere, o => o.MapFrom(s => s.RubriqueMere.LibelleRubrique));
            CreateMap<RubriqueRubriqueMereDTOOut, Rubrique>();
            CreateMap<Rubrique, RubriqueDTOOut>();
            CreateMap<RubriqueDTOOut, Rubrique>();
        }
    }
}
