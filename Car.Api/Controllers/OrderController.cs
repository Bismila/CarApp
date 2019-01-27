using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Car.Api.ViewModels;
using Car.BLL.DTO;
using Car.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Car.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public OrderController(IMapper mapper, IUserService userService, IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
            _userService = userService;
        }
        // GET api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
           return new string[] { "value1", "value2" };
        }

        // POST api/user
        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] OrdersViewModel order)
        {
            if (ModelState.IsValid && order != null)
            {
                if (!await _userService.ExistUser(order.User.Email))
                {
                    await _userService.Create(_mapper.Map<UsersDto>(order.User));
                }
                await _orderService.Create(_mapper.Map<OrdersDto>(order));
                return Ok("200");
            }
            return BadRequest("false");

        }
    }
}
