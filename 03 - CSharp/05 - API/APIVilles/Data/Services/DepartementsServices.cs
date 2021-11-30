using ApiVilles;
using APIVilles.Data.Dtos;
using APIVilles.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVilles.Data.Services
{
    public class DepartementsServices
    {

        private readonly MyDbContext _context;

        public DepartementsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddDepartement(DepartementsDTOIn obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            var ent = new Departement()
            {
                Nom = obj.Nom,
            };
            _context.Add(ent);
            _context.SaveChanges();
        }

        public void DeleteDepartement(Departement obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Departements.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Departement> GetAllDepartements()
        {
            //var liste = (from e1 in _context.Departements
            //             select new Departement
            //             {
            //                 IdDepartement = e1.IdDepartement,
            //                 Nom = e1.Nom,
            //                 LesVilles = _context.Villes.Where(v => v.IdDepartement == e1.IdDepartement).ToList()
            //             }).ToList();
            //return liste;
           return _context.Departements.Include("LesVilles").ToList();
        }

        public Departement GetDepartementById(int id)
        {
            return _context.Departements.Include("LesVilles").FirstOrDefault(obj => obj.IdDepartement == id);
        }

        public void UpdateDepartement(Departement obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }


    }
}
