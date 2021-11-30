using APIAeroport.Data.Dtos;
using APIAeroport.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Profiles
{
    public class TrajetProfiles : Profile
    {
        public TrajetProfiles()
        {
            CreateMap<Trajet, TrajetDTO>();
            CreateMap<TrajetDTO, Trajet>();
            CreateMap<Trajet, TrajetVolDTO>();
            CreateMap<TrajetVolDTO, Trajet>();
        }
    }
}
