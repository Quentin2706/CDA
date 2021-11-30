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
            CreateMap<Departement, DepartementsDTOListe>();
            CreateMap<DepartementsDTOListe, Departement>();
            CreateMap<Departement, DepartementsDTOIn>();
            CreateMap<DepartementsDTOIn, Departement>();
            CreateMap<Departement, DepartementsDTOUpdate>();
            CreateMap<DepartementsDTOUpdate, Departement>();
        }
    }
}
