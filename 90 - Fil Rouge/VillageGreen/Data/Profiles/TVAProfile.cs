﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;
using VillageGreen.Data.Dtos;

namespace VillageGreen.Data.Profiles
{
    class TVAProfile : Profile
    {
        public TVAProfile()
        {
            CreateMap<TVA, TVADTOIn>();
            CreateMap<TVADTOIn, TVA>();
            CreateMap<TVA, TVADTOOut>();
            CreateMap<TVADTOOut, TVA>();
        }
    }
}
