using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class ReglementServices
    {

        private readonly VGContext _context;

        public ReglementServices(VGContext context)
        {
            _context = context;
        }

        public void AddReglement(Reglement obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Reglements.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteReglement(Reglement obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Reglements.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Reglement> GetAllReglement()
        {
            return _context.Reglements.ToList();
        }

        public Reglement GetReglementById(int id)
        {
            return _context.Reglements.FirstOrDefault(obj => obj.IdReglement == id);
        }

        public void UpdateReglement(Reglement obj)
        {
            _context.SaveChanges();
        }


    }
}
