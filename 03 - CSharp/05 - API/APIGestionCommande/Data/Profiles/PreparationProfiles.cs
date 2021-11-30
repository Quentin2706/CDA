using APIGestionCommande.Data.Dtos;
using APIGestionCommande.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestionCommande.Data.Profiles
{
    public class PreparationProfiles : Profile
    {
        public PreparationProfiles()
        {
            CreateMap<Preparation, PreparationDTO>();
            CreateMap<PreparationDTO, Preparation>();
        }

    }
}
