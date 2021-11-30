using APIAeroport.Data.Dtos;
using APIAeroport.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Profiles
{
    public class VolProfiles : Profile
    {
        public VolProfiles()
        {
            CreateMap<Vol, VolDTO>();
            CreateMap<VolDTO, Vol>();
        }
    }
}