using APIGestionCommande.Data.Dtos;
using APIGestionCommande.Data.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGestionCommande.Data.Profiles
{
    public class CommandeProfiles : Profile
    {
        public CommandeProfiles()
        {
            CreateMap<Commande, CommandeDTO>();
            CreateMap<CommandeDTO, Commande>();
            CreateMap<Commande, CommandePreparationDTO>();
            CreateMap<CommandePreparationDTO, Commande>();

        }

    }
}
