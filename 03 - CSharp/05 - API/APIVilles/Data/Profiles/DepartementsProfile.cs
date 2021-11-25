using APIVilles.Data.Dtos;
using APIVilles.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Profiles
{
    public class DepartementsProfile : Profile
    {
        public DepartementsProfile()
        {
            CreateMap<Departement, DepartementsDTO>();
            CreateMap<DepartementsDTO, Departement>();
        }
    }
}
