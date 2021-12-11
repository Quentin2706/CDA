using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class PaysServices
    {

        private readonly VGContext _context;

        public PaysServices(VGContext context)
        {
            _context = context;
        }

        public void AddPays(Pays obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pays.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePays(Pays obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pays.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Pays> GetAllPays()
        {
            return _context.Pays.ToList();
        }

        public Pays GetPaysById(int id)
        {
            return _context.Pays.FirstOrDefault(obj => obj.IdPays == id);
        }

        public void UpdatePays(Pays obj)
        {
            _context.SaveChanges();
        }


    }
}
