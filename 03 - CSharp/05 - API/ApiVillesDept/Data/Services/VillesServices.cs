using ApiVillesDept;
using ApiVillesDept.Data;
using ApiVillesDept.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVillesDept.Data.Services
{
    public class VillesServices 
    {

        private readonly LeContext _context;

        public VillesServices(LeContext context)
        {
            _context = context;
        }

        public void AddVille(Ville obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Villes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteVille(Ville obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Villes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Ville> GetAllVilles()
        {
            var liste = (from e1 in _context.Villes
                         join e2 in _context.Departements
                         on e1.IdDepartement equals e2.IdDepartement
                         select new Ville
                         {
                             IdVille = e1.IdVille,
                             Nom = e1.Nom,
                             IdDepartement = e2.IdDepartement,
                             Dept = e2
                         }).ToList();
            liste[0].Dump();
            return liste;
            // return _context.Villes.ToList();
        }

        public Ville GetVilleById(int id)
        {
            var result = (from e1 in _context.Villes
                          join e2 in _context.Departements
                          on e1.IdDepartement equals e2.IdDepartement
                          where e1.IdVille == id
                          select new Ville
                          {
                              IdVille = e1.IdVille,
                              Nom = e1.Nom,
                              IdDepartement = e2.IdDepartement,
                              Dept = e2
                          });
            return result.FirstOrDefault();
        }

        public void UpdateVille(Ville obj)
        {
            
            _context.SaveChanges();
        }


    }
}
