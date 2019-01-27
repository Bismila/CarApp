using Car.DAL.Entities;
using Car.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.DAL.Repositories
{
    public class CarRepository: ICarRepository
    {
        private readonly CarDbContext _db;

        public CarRepository(CarDbContext db)
        {
            _db = db;
        }
        public async Task Create(Cars item)
        {
            await _db.Cars.AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Cars>> GetAll()
        {
            return await _db.Cars.ToListAsync<Cars>();
        }

        public async Task<Cars> GetCarByName(string carName)
        {
            Cars car = await _db.Cars.Where(c => c.Name == carName).FirstOrDefaultAsync();
            return car;
        }

        public async Task Update(Cars item)
        {
            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
