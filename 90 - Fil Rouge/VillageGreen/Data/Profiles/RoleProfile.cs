using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;
using VillageGreen.Data.Dtos;

namespace VillageGreen.Data.Profiles
{
    class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDTOIn>();
            CreateMap<RoleDTOIn, Role>();
            CreateMap<Role, RoleDTOOut>();
            CreateMap<RoleDTOOut, Role>();
        }
    }
}
