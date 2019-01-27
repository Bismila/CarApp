using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Car.BLL.Interfaces;
using Car.Api.ViewModels;
using Car.BLL.DTO;

namespace Car.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _usersService;

        public UserController(IMapper mapper,
                              IUserService usersService)
        {
            _mapper = mapper;
            _usersService = usersService;
        }

        [HttpPut()]
        public async Task<ActionResult<bool>> Put([FromBody] UsersViewModel user)
        {
            try
            {
                return await _usersService.Update(_mapper.Map<UsersDto>(user));
              
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

    }
}
