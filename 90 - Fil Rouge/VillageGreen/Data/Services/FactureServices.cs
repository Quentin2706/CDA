using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class FactureServices
    {

        private readonly VGContext _context;

        public FactureServices(VGContext context)
        {
            _context = context;
        }

        public void AddFacture(Facture obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Factures.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteFacture(Facture obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Factures.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Facture> GetAllFacture()
        {
            return _context.Factures.ToList();
        }

        public Facture GetFactureById(int id)
        {
            return _context.Factures.FirstOrDefault(obj => obj.IdFacture == id);
        }

        public void UpdateFacture(Facture obj)
        {
            _context.SaveChanges();
        }


    }
}
