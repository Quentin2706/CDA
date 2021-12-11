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
    class ProduitProfile : Profile
    {
        public ProduitProfile()
        {

        CreateMap<Produit, ProduitDTOIn>();
        CreateMap<ProduitDTOIn, Produit>();
        CreateMap<Produit, ProduitDTOOut>()
            .ForMember(d => d.LibelleRubrique, o => o.MapFrom(s => s.Rubrique.LibelleRubrique));
        CreateMap<ProduitDTOOut, Produit>();
        }
    }
}
