using APIVoitures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVoitures.Data.Services
{
    public class VoituresService
    {
        private readonly MyDbContext _context;

        public VoituresService(MyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Voiture> GetAllVoitures()
        {
            return _context.Voitures.ToList();
        }
    }
}
