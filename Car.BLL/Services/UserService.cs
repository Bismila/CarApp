using AutoMapper;
using Car.BLL.DTO;
using Car.BLL.Interfaces;
using Car.BLL.MapperProvider;
using Car.DAL.Entities;
using Car.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car.BLL.Services
{
    public class UserService: IUserService
    {
        private IAutoMapperProvider _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IAutoMapperProvider mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task Create(UsersDto item)
        {
            try
            {
                await _userRepository.Create(_mapper.Mapper.Map<Users>(item));

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<bool> ExistUser(string userEmail)
        {
            var currentUser = await _userRepository.GetByEmail(userEmail);
            if (currentUser == null)
                return false;
            return true;
        }

        public async Task<bool> Update(UsersDto item)
        {
            if (await ExistUser(item.Email))
            {
                await _userRepository.Update(_mapper.Mapper.Map<Users>(item));
                return true;
            }
            return false;
        }
    }
}
