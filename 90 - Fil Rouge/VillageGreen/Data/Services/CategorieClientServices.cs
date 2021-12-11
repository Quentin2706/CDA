using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class CategorieClientServices
    {

        private readonly VGContext _context;

        public CategorieClientServices(VGContext context)
        {
            _context = context;
        }

        public void AddCategorieClient(CategorieClient obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.CategoriesClient.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCategorieClient(CategorieClient obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.CategoriesClient.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<CategorieClient> GetAllCategorieClient()
        {
            return _context.CategoriesClient.ToList();
        }

        public CategorieClient GetCategorieClientById(int id)
        {
            return _context.CategoriesClient.FirstOrDefault(obj => obj.IdCategorieClient == id);
        }

        public void UpdateCategorieClient(CategorieClient obj)
        {
            _context.SaveChanges();
        }


    }
}
