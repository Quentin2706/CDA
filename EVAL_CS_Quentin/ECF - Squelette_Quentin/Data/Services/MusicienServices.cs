using ECF.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Services
{
    class MusicienServices
    {

        private readonly EcfContext _context;

        public MusicienServices(EcfContext context)
        {
            _context = context;
        }

        public void AddMusicien(Musicien obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Musiciens.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteMusicien(Musicien obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Musiciens.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Musicien> GetAllMusiciens()
        {
            return _context.Musiciens.ToList();
        }

        /* Modif => j'ai rajouté cette méthode c'est cohérent avec le controller*/
        public IEnumerable<Musicien> GetAllMusiciensAvecGroupe()
        {
            return _context.Musiciens.Include("IdGroupeNavigation").ToList();
        }

        public Musicien GetMusicienById(int id)
        {
            return _context.Musiciens.FirstOrDefault(obj => obj.IdMusicien == id);
        }

        public void UpdateMusicien(Musicien obj)
        {
            _context.SaveChanges();
        }


    }
}
