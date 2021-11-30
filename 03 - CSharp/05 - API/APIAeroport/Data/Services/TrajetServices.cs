﻿using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Services
{
    public class TrajetServices
    {

        private readonly aeroportContext _context;

        public TrajetServices(aeroportContext context)
        {
            _context = context;
        }

        public void AddTrajet(Trajet obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Trajets.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteTrajet(Trajet obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Trajets.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Trajet> GetAllTrajet()
        {
            return _context.Trajets.ToList();
        }

        public Trajet GetTrajetById(int id)
        {
            return _context.Trajets.FirstOrDefault(obj => obj.IdTrajet == id);
        }

        public void UpdateTrajet(Trajet obj)
        {
            _context.SaveChanges();
        }


    }
}
