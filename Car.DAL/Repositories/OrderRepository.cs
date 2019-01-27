using Car.DAL.Entities;
using Car.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car.DAL.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly CarDbContext _db;

        public OrderRepository(CarDbContext db)
        {
            _db = db;
        }

        public async Task Create(Orders item)
        {
            try
            {
                await _db.Orders.AddAsync(item);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public Task<List<Orders>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Orders item)
        {
            _db.Entry(item).State = EntityState.Modified;
            await _db.SaveChangesAsync();
        }
    }
}
