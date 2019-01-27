using Car.DAL.Entities;
using Car.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.DAL.Repositories
{
    public class SupportRepository: ISupportRepository
    {
        private readonly CarDbContext _db;
        public SupportRepository(CarDbContext db)
        {
            _db = db;
        }

        public async Task Create(Supports item)
        {
            await _db.Supports.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Supports>> GetAll()
        {
            var supports = await _db.Supports.ToListAsync<Supports>();
            return supports;
        }
        public async Task<Supports> GetSupportsByName(string supportsName)
        {
            var supports = await _db.Supports.Where(s => s.Name == supportsName).FirstOrDefaultAsync();
            return supports;
        }

        public async Task Update(Supports item)
        {
            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
