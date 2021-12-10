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
    class ApprovisionnementProfile : Profile
    {
        public ApprovisionnementProfile()
        {
            CreateMap<Approvisionnement, ApprovisionnementDTOIn>();
            CreateMap<ApprovisionnementDTOIn, Approvisionnement>();
            CreateMap<Approvisionnement, ApprovisionnementDTOOut>()
            .ForMember(d => d.LibelleProduit, o => o.MapFrom(s => s.Produit.LibelleProduit))
            .ForMember(d => d.RefProduit, o => o.MapFrom(s => s.Produit.RefProduit))
            .ForMember(d => d.NomFournisseur, o => o.MapFrom(s => s.Fournisseur.NomFournisseur));
            CreateMap<ApprovisionnementDTOOut, Approvisionnement>();
        }
    }
}
