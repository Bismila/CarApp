using Car.BLL.DTO;
using Car.BLL.Interfaces;
using Car.BLL.MapperProvider;
using Car.DAL.Entities;
using Car.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.BLL.Services
{
    public class OrderService: IOrderService
    {
        private IAutoMapperProvider _mapper;
        private readonly IOrderRepository _orderRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICarRepository _carRepository;
        private readonly ISupportRepository _supportsRepository;


        public OrderService(IAutoMapperProvider mapper,
                            IOrderRepository orderRepository,
                            IUserRepository userRepository,
                            ICarRepository carRepository,
                            ISupportRepository supportsRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _carRepository = carRepository;
            _supportsRepository = supportsRepository;
        }
        public async Task Create(OrdersDto item)
        {
            var currentUser = await _userRepository.GetByEmail(item.UserEmail);
            var car = await _carRepository.GetCarByName(item.CarName);
            var supports = await _supportsRepository.GetSupportsByName(item.SupportsName);
            item.UserId = currentUser.Id;
            item.CarId = car.Id;
            item.SupportsId = supports.Id;
           
            if (currentUser != null)
            {
                await _orderRepository.Create(_mapper.Mapper.Map<Orders>(item));
            }
           
        }

        public async Task<bool> Update(OrdersDto item)
        {
            throw new NotImplementedException();
        }
    }
}
