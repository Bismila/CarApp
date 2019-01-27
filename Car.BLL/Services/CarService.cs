using Car.BLL.DTO;
using Car.BLL.Interfaces;
using Car.BLL.MapperProvider;
using Car.DAL.Entities;
using Car.DAL.Interfaces;
using Car.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.BLL.Services
{
    public class CarService : IBaseService<CarsDto>, ICarsService
    {
        private IAutoMapperProvider _mapper;
        private readonly ICarRepository _carRepository;
        public CarService(IAutoMapperProvider mapper, ICarRepository carRepository)
        {
            _mapper = mapper;
            _carRepository = carRepository;
        }
        public async Task Create(CarsDto item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetAll()
        {
            var cars = await _carRepository.GetAll();

            var list = new List<string>();
            foreach (var model in cars)
            {
                list.Add(model.Name);
            }
            return list;
        }

        public async Task<bool> Update(CarsDto item)
        {
            throw new NotImplementedException();
        }
    }
}
