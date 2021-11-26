using ApiVilles;
using APIVilles.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Services
{
    public class VillesServices 
    {

        private readonly MyDbContext _context;

        public VillesServices(MyDbContext context)
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
                             Departement = e2
                         }).ToList();
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
                              Departement = e2
                          });
            return result.FirstOrDefault();
        }

        public void UpdateVille(Ville obj)
        {
            
            _context.SaveChanges();
        }


    }
}
