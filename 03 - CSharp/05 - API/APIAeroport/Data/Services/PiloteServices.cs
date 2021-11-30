using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Services
{
    public class PiloteServices
    {

        private readonly aeroportContext _context;

        public PiloteServices(aeroportContext context)
        {
            _context = context;
        }

        public void AddPilote(Pilote obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pilotes.Add(obj);
            _context.SaveChanges();
        }

        public void DeletePilote(Pilote obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Pilotes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Pilote> GetAllPilote()
        {
            return _context.Pilotes.ToList();
        }

        public Pilote GetPiloteById(int id)
        {
            return _context.Pilotes.FirstOrDefault(obj => obj.IdPilote == id);
        }

        public void UpdatePilote(Pilote obj)
        {
            _context.SaveChanges();
        }


    }
}
