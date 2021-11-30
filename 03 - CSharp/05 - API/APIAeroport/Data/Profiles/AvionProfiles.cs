using APIAeroport.Data.Dtos;
using APIAeroport.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Profiles
{
    public class AvionProfiles : Profile
    {
        public AvionProfiles()
        {
            CreateMap<Avion, AvionDTO>();
            CreateMap<AvionDTO, Avion>();
            CreateMap<Avion, AvionVolDTO>();
            CreateMap<AvionVolDTO, Avion>();
        }
    }
}
