using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillageGreen.Data.Models;

namespace VillageGreen.Data.Services
{
    class UserServices
    {

        private readonly VGContext _context;

        public UserServices(VGContext context)
        {
            _context = context;
        }

        public void AddUser(User obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Users.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteUser(User obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Users.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(obj => obj.IdUser == id);
        }

        public void UpdateUser(User obj)
        {
            _context.SaveChanges();
        }


    }
}
