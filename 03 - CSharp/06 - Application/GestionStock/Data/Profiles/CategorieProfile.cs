using AutoMapper;
using GestionStock.Data.Dtos;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Profiles
{
    class CategorieProfile : Profile
    {
        public CategorieProfile()
        { 
            CreateMap<Categorie, CategorieDTOOut>();
            CreateMap<CategorieDTOOut, Categorie>();
        }
    }
}
