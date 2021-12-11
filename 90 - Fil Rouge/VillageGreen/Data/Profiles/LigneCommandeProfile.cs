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
    class LigneCommandeProfile : Profile
    {
        public LigneCommandeProfile()
        {
        CreateMap<LigneCommande, LigneCommandeDTOIn>();
            CreateMap<LigneCommandeDTOIn, LigneCommande>();
            CreateMap<LigneCommande, LigneCommandeDTOOut>()
                .ForMember(d => d.LibelleProduit, o => o.MapFrom(s => s.Produit.LibelleProduit))
                .ForMember(d => d.RefProduit, o => o.MapFrom(s => s.Produit.RefProduit))
                .ForMember(d => d.PrixHorsTaxe, o => o.MapFrom(s => s.Produit.PrixHorsTaxe))
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
                .ForMember(d => d.DateCommande, o => o.MapFrom(s => s.Commande.DateCommande));
            CreateMap<LigneCommandeDTOOut, LigneCommande>();
        }
    }
}
