using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class HistoriqueTVAServices
    {

        private readonly VGContext _context;

        public HistoriqueTVAServices(VGContext context)
        {
            _context = context;
        }

        public void AddHistoriqueTVA(HistoriqueTVA obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.HistoriqueTVA.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteHistoriqueTVA(HistoriqueTVA obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.HistoriqueTVA.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<HistoriqueTVA> GetAllHistoriqueTVA()
        {
            return _context.HistoriqueTVA.ToList();
        }

        public HistoriqueTVA GetHistoriqueTVAById(int id)
        {
            return _context.HistoriqueTVA.FirstOrDefault(obj => obj.IdHistoriqueTVA == id);
        }

        public void UpdateHistoriqueTVA(HistoriqueTVA obj)
        {
            _context.SaveChanges();
        }


    }
}
