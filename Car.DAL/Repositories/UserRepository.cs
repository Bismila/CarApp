using Car.DAL.Entities;
using Car.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Car.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CarDbContext _db;
        public UserRepository(CarDbContext db)
        {
            _db = db;
        }
        public async Task Create(Users item)
        {
            await _db.Users.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public Task<List<Users>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Users> GetByEmail(string email)
        {
            Users user = await _db.Users.Where(u=>u.Email == email).FirstOrDefaultAsync();
            return user;
        }

        public async Task Update(Users item)
        {
            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
