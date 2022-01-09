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
    class HistoriqueTVAProfile : Profile
    {
        public HistoriqueTVAProfile()
        {
            CreateMap<HistoriqueTVA, HistoriqueTVADTOIn>();
            CreateMap<HistoriqueTVADTOIn, HistoriqueTVA>();
            CreateMap<HistoriqueTVA, HistoriqueTVADTOOut>()
                .ForMember(d => d.LibelleProduit, o => o.MapFrom(s => s.Produit.LibelleProduit))
                .ForMember(d => d.RefProduit, o => o.MapFrom(s => s.Produit.RefProduit))
                .ForMember(d => d.LibelleRubrique, o => o.MapFrom(s => s.Produit.Rubrique.LibelleRubrique))
                .ForMember(d => d.TauxTVA, o => o.MapFrom(s => s.TVA.TauxTVA))
                .ForMember(d => d.DateTVA, o => o.MapFrom(s => ((DateTime)s.DateTVA).ToString("dd-MM-yyyy")));
            CreateMap<HistoriqueTVADTOOut, HistoriqueTVA>();
        }
    }
}
