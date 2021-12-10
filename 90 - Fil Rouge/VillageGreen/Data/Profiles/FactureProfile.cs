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
    class FactureProfile : Profile
    {
        public FactureProfile()
        {
            CreateMap<Facture, FactureDTOIn>();
            CreateMap<FactureDTOIn, Facture>();
            CreateMap<Facture, FactureDTOOut>()
                .ForMember(d => d.TypePaiement, o => o.MapFrom(s => s.Reglement.TypePaiement))
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
                .ForMember(d => d.DateCommande, o => o.MapFrom(s => s.Commande.DateCommande));
            CreateMap<FactureDTOOut, Facture>();
            CreateMap<Facture, FactureDetailDTOOut>()
                .ForMember(d => d.TypePaiement, o => o.MapFrom(s => s.Reglement.TypePaiement))
                .ForMember(d => d.NumeroCommande, o => o.MapFrom(s => s.Commande.NumeroCommande))
                .ForMember(d => d.DateCommande, o => o.MapFrom(s => s.Commande.DateCommande))
                .ForMember(d => d.RefClient, o => o.MapFrom(s => s.Commande.Client.RefClient))
                .ForMember(d => d.CoefClient, o => o.MapFrom(s => s.Commande.Client.CoefClient))
                .ForMember(d => d.LibelleCategClient, o => o.MapFrom(s => s.Commande.Client.CategorieClient.LibelleCategClient))
                .ForMember(d => d.InfoReglement, o => o.MapFrom(s => s.Commande.Client.CategorieClient.InfoReglement))
                .ForMember(d => d.EmailAdresse, o => o.MapFrom(s => s.Commande.Adresse.EmailAdresse))
                .ForMember(d => d.AdressePostale, o => o.MapFrom(s => s.Commande.Adresse.AdressePostale))
                .ForMember(d => d.TelMobile, o => o.MapFrom(s => s.Commande.Adresse.TelMobile))
                .ForMember(d => d.TelFixe, o => o.MapFrom(s => s.Commande.Adresse.TelFixe))
                .ForMember(d => d.Province, o => o.MapFrom(s => s.Commande.Adresse.Province))
                .ForMember(d => d.ComplementAdresse, o => o.MapFrom(s => s.Commande.Adresse.ComplementAdresse))
                .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Commande.Adresse.Ville.LibelleVille))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Commande.Adresse.Ville.CodePostal))
                .ForMember(d => d.NomPays, o => o.MapFrom(s => s.Commande.Adresse.Ville.Pays.NomPays));
            CreateMap<FactureDetailDTOOut, Facture>();
        }
    }
}
