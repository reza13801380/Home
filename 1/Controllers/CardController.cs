using _1.Commands;
using _1.Models;
using _1.Repository;
using _1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICsmService _csmService;
        public CardController(ICsmService csmService)
        {
            _csmService = csmService;
        }
        [HttpPost("AddCart")]
        public async Task<IActionResult> AddCart(AddCartCommand command)
        {
            var result = await _csmService.AddCart(command);    
            return Ok(result);
        }
        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAllCarts()
        //{
        //    //var result = await _csmService.GetAllCarts();
        //    //return Ok(result);
        //}
    }
}
