using AutoMapper;
using Car.BLL.DTO;
using Car.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car.BLL.MapperProvider
{
    public interface IAutoMapperProvider
    {
        IMapper Mapper { get; }
    }

    public class AutoMapperProvider : IAutoMapperProvider
    {
        public IMapper Mapper
        {
            get
            {
                return new MapperConfiguration(map =>
                {
                    map.CreateMap<Users, UsersDto>().ReverseMap();
                    map.CreateMap<Cars, CarsDto>().ReverseMap();
                    map.CreateMap<Orders, OrdersDto>().ReverseMap();
                    map.CreateMap<Supports, SupportsDto>().ReverseMap();

                }).CreateMapper();
            }
           
        }
    }
}
