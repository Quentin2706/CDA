using AutoMapper;
using ECF.Data.Dtos;
using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Profiles
{
    public class MusicienProfiles : Profile
    {
        public  MusicienProfiles()
        {
            CreateMap<Musicien, MusiciensDTOIn>();
            CreateMap<MusiciensDTOIn, Musicien>();

            CreateMap<Musicien, MusiciensDTOOut>();
            CreateMap<MusiciensDTOOut, Musicien>();


            CreateMap<Musicien, MusiciensDTOOutAvecGroupe>()
                .ForMember(x => x.NomDuGroupe, y => y.MapFrom(z => z.IdGroupeNavigation.NomDuGroupe));
            CreateMap<MusiciensDTOOutAvecGroupe, Musicien>();

           
        }
    }
}
