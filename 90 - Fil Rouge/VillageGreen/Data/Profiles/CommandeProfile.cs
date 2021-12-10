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
    class CommandeProfile : Profile
    {
        public CommandeProfile()
        {
            CreateMap<Commande, CommandeDTOIn>();
            CreateMap<CommandeDTOIn, Commande>();
            CreateMap<Commande, CommandeDTOOut>()
                .ForMember(d => d.RefClient, o => o.MapFrom(s => s.Client.RefClient))
                .ForMember(d => d.InfoReglement, o => o.MapFrom(s => s.Client.CategorieClient.InfoReglement))
                .ForMember(d => d.AdressePostale, o => o.MapFrom(s => s.Adresse.AdressePostale))
                .ForMember(d => d.Province, o => o.MapFrom(s => s.Adresse.Province))
                .ForMember(d => d.ComplementAdresse, o => o.MapFrom(s => s.Adresse.ComplementAdresse))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Adresse.Ville.CodePostal));

            //.ForMember(d => d.LibelleCategCommande, o => o.MapFrom(s => s.CategorieCommande.LibelleCategCommande));
            CreateMap<CommandeDTOOut, Commande>();
            
            CreateMap<Commande, CommandeDetailDTOOut>()
                .ForMember(d => d.RefClient, o => o.MapFrom(s => s.Client.RefClient))
                .ForMember(d => d.CoefClient, o => o.MapFrom(s => s.Client.CoefClient))
                .ForMember(d => d.LibelleCategClient, o => o.MapFrom(s => s.Client.CategorieClient.LibelleCategClient))
                .ForMember(d => d.InfoReglement, o => o.MapFrom(s => s.Client.CategorieClient.InfoReglement))
                .ForMember(d => d.EmailAdresse, o => o.MapFrom(s => s.Adresse.EmailAdresse))
                .ForMember(d => d.TelMobile, o => o.MapFrom(s => s.Adresse.TelMobile))
                .ForMember(d => d.TelFixe, o => o.MapFrom(s => s.Adresse.TelFixe))
                .ForMember(d => d.AdressePostale, o => o.MapFrom(s => s.Adresse.AdressePostale))
                .ForMember(d => d.Province, o => o.MapFrom(s => s.Adresse.Province))
                .ForMember(d => d.ComplementAdresse, o => o.MapFrom(s => s.Adresse.ComplementAdresse))
                .ForMember(d => d.LibelleVille, o => o.MapFrom(s => s.Adresse.Ville.LibelleVille))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Adresse.Ville.CodePostal))
                .ForMember(d => d.CodePostal, o => o.MapFrom(s => s.Adresse.Ville.Pays.NomPays));
            CreateMap<CommandeDetailDTOOut, Commande>();
        }
    }
}
