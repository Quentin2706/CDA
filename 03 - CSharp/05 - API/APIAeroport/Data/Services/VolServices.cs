﻿using APIAeroport.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAeroport.Data.Services
{
    public class VolServices
    {

        private readonly aeroportContext _context;

        public VolServices(aeroportContext context)
        {
            _context = context;
        }

        public void AddVol(Vol obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Vols.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteVol(Vol obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Vols.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Vol> GetAllVol()
        {
            return _context.Vols.ToList();
        }

        public Vol GetVolById(int id)
        {
            return _context.Vols.FirstOrDefault(obj => obj.IdVol == id);
        }

        public void UpdateVol(Vol obj)
        {
            _context.SaveChanges();
        }


    }
}
