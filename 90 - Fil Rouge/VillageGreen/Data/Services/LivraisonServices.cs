using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class LivraisonServices
    {

        private readonly VGContext _context;

        public LivraisonServices(VGContext context)
        {
            _context = context;
        }

        public void AddLivraison(Livraison obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Livraisons.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteLivraison(Livraison obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Livraisons.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Livraison> GetAllLivraison()
        {
            return _context.Livraisons.ToList();
        }

        public Livraison GetLivraisonById(int id)
        {
            return _context.Livraisons.FirstOrDefault(obj => obj.IdLivraison == id);
        }

        public void UpdateLivraison(Livraison obj)
        {
            _context.SaveChanges();
        }


    }
}
