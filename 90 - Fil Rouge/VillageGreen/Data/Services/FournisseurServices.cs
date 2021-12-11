using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class FournisseurServices
    {

        private readonly VGContext _context;

        public FournisseurServices(VGContext context)
        {
            _context = context;
        }

        public void AddFournisseur(Fournisseur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Fournisseurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteFournisseur(Fournisseur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Fournisseurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Fournisseur> GetAllFournisseur()
        {
            return _context.Fournisseurs.ToList();
        }

        public Fournisseur GetFournisseurById(int id)
        {
            return _context.Fournisseurs.FirstOrDefault(obj => obj.IdFournisseur == id);
        }

        public void UpdateFournisseur(Fournisseur obj)
        {
            _context.SaveChanges();
        }


    }
}
