using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Car.BLL.Interfaces;

namespace Car.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISupportService _supportService;

        public SupportController(IMapper mapper,
                              ISupportService supportService)
        {
            _mapper = mapper;
            _supportService = supportService;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<List<string>>> GetAll()
        {
            try
            {
                var listSupports = await _supportService.GetAll();
                return listSupports;
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    
    }
}
