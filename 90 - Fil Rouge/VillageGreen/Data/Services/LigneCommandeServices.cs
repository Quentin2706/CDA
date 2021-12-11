using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class LigneCommandeServices
    {

        private readonly VGContext _context;

        public LigneCommandeServices(VGContext context)
        {
            _context = context;
        }

        public void AddLigneCommande(LigneCommande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.LignesCommande.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteLigneCommande(LigneCommande obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.LignesCommande.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<LigneCommande> GetAllLigneCommande()
        {
            return _context.LignesCommande.ToList();
        }

        public LigneCommande GetLigneCommandeById(int id)
        {
            return _context.LignesCommande.FirstOrDefault(obj => obj.IdLigneCommande == id);
        }

        public void UpdateLigneCommande(LigneCommande obj)
        {
            _context.SaveChanges();
        }


    }
}
