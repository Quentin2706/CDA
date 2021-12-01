using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class CategorieServices
    {

        private readonly GestionStockContext _context;

        public CategorieServices(GestionStockContext context)
        {
            _context = context;
        }

        public void AddCategorie(Categorie obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCategorie(Categorie obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Categories.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Categorie> GetAllCategorie()
        {
            return _context.Categories.ToList();
        }

        public Categorie GetCategorieById(int id)
        {
            return _context.Categories.FirstOrDefault(obj => obj.IdCategorie == id);
        }

        public void UpdateCategorie(Categorie obj)
        {
            _context.SaveChanges();
        }


    }
}
