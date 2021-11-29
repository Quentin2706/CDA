using APIVilles.Data.Dtos;
using ApiVillesDept.Data.Models;
using APIVillesDept.Data.Dtos;
using APIVillesDept.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVillesDept.Data.Profiles
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
