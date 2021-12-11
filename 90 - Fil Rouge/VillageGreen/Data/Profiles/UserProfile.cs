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
    class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTOIn>();
            CreateMap<UserDTOIn, User>();
            CreateMap<User, UserDTOOut>()
                .ForMember(d => d.LibelleRole, o => o.MapFrom(s => s.Role.LibelleRole));
            CreateMap<UserDTOOut, User>();
        }
    }
}
