using APIVoitures.Data.Dtos;
using APIVoitures.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVoitures.Data.Profiles
{
    public class VoituresProfile : Profile
    {   
        public VoituresProfile()
        {
            CreateMap<Voiture, VoituresDTO>();
            CreateMap<VoituresDTO, Voiture>();
        }
    }
}
