using AutoMapper;
using Car.Api.ViewModels;
using Car.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Api.MapperProvider
{
    public class AutoMapperConfig
    {

        public static IMapper ConfigureAutoMapper()
        {
            IMapper mapper = new MapperConfiguration(map =>
            {
                map.CreateMap<UsersDto, UsersViewModel>().ReverseMap();
                map.CreateMap<CarsDto, CarsViewModel>().ReverseMap();
                map.CreateMap<OrdersDto, OrdersViewModel>().ReverseMap();
                map.CreateMap<SupportsDto, SupportsViewModel>().ReverseMap();

            }).CreateMapper();

            return mapper;
        }
    }
}
