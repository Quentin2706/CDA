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
    class ReglementProfile : Profile
    {
        public ReglementProfile()
        {
            CreateMap<Reglement, ReglementDTOIn>();
            CreateMap<ReglementDTOIn, Reglement>();
            CreateMap<Reglement, ReglementDTOOut>();
            CreateMap<ReglementDTOOut, Reglement>();
        }
    }
}
