using APIAeroport.Data.Dtos;
using APIAeroport.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Profiles
{
    public class PiloteProfiles : Profile
    {
        public PiloteProfiles()
        {
            CreateMap<Pilote, PiloteDTO>();
            CreateMap<PiloteDTO, Pilote>();
            CreateMap<Avion, PiloteVolDTO>();
            CreateMap<PiloteVolDTO, Avion>();
        }
    }
}
