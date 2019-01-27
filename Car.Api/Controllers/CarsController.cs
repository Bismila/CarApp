using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Car.BLL.Interfaces;
using Car.BLL.Services;

namespace Car.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICarsService _carsService;

        public CarsController(IMapper mapper,
                              ICarsService carsService)
        {
            _mapper = mapper;
            _carsService = carsService;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<List<string>>> GetCars()
        {
            try
            {
                var listCars = await _carsService.GetAll();
                return listCars;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    
    }
}
