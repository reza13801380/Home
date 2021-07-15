﻿using _1.Commands;
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
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCarts(Guid id )
        {
            var result = await _csmService.GetAllCarts(id);
            return Ok(result);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetCardById(Guid id)
        {
            var result = await _csmService.GetCardById(id);
            return Ok(result);
        }
        [HttpPut("{id}/Update-cart")]
        public async Task<IActionResult> EditCart(Guid id, UpdateCartCommand command)
        {
            command.ID = id;
            var Cart = await _csmService.EditCart(command);
            return Ok(Cart);
        }
        
            
    

    }
}