using ApiVilles;
using APIVilles.Data.Models;
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

        public void AddDepartement(Departement obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Departements.Add(obj);
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
            var liste = (from e1 in _context.Villes
                         join e2 in _context.Departements
                         on e1.IdDepartement equals e2.IdDepartement
                         select new Departement
                         {
                             IdDepartement = e1.IdDepartement,
                             Nom = e1.Nom,
                             LesVilles = (from e3 in _context.Villes
                                          join e4 in _context.Departements
                                          on e3.IdDepartement equals e4.IdDepartement
                                          select new Ville {
                                              IdVille = e3.IdVille,
                                              Nom = e3.Nom,
                                              IdDepartement = e1.IdDepartement,
                                              Dept = e4
                                          }).ToList()
                         }).ToList();
            return liste;
        }

        public Departement GetDepartementById(int id)
        {
            return _context.Departements.FirstOrDefault(obj => obj.IdDepartement == id);
        }

        public void UpdateDepartement(Departement obj)
        {
            _context.SaveChanges();
        }


    }
}
