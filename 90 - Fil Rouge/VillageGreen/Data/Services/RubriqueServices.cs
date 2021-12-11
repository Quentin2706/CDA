using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class RubriqueServices
    {

        private readonly VGContext _context;

        public RubriqueServices(VGContext context)
        {
            _context = context;
        }

        public void AddRubrique(Rubrique obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Rubriques.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteRubrique(Rubrique obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Rubriques.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Rubrique> GetAllRubrique()
        {
            return _context.Rubriques.ToList();
        }

        public Rubrique GetRubriqueById(int id)
        {
            return _context.Rubriques.FirstOrDefault(obj => obj.IdRubrique == id);
        }

        public void UpdateRubrique(Rubrique obj)
        {
            _context.SaveChanges();
        }


    }
}
