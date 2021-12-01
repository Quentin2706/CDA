using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class TypeProduitServices
    {

        private readonly GestionStockContext _context;

        public TypeProduitServices(GestionStockContext context)
        {
            _context = context;
        }

        public void AddTypeProduit(TypeProduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypesProduits.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTypeProduit(TypeProduit obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.TypesProduits.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TypeProduit> GetAllTypeProduit()
        {
            return _context.TypesProduits.ToList();
        }

        public TypeProduit GetTypeProduitById(int id)
        {
            return _context.TypesProduits.FirstOrDefault(obj => obj.IdTypeProduit == id);
        }

        public void UpdateTypeProduit(TypeProduit obj)
        {
            _context.SaveChanges();
        }


    }
}
