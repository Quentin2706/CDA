using APIGestionCommande.Data.Dtos;
using APIGestionCommande.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestionCommande.Data.Profiles
{
    public class ProduitProfiles : Profile
    {
        public ProduitProfiles()
        {
            CreateMap<Produit, ProduitDTO>();
            CreateMap<ProduitDTO, Produit>();
            CreateMap<Produit, ProduitPreparationDTO>();
            CreateMap<ProduitPreparationDTO, Produit>();

        }

    }
}

