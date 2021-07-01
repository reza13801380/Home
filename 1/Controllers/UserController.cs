using _1.Commands;
using _1.Repository;
using _1.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICsmService _csmService;

        public UserController(ICsmService csmService)
        {
            _csmService = csmService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser(LoginUserCommand command)
        {
            var result = await _csmService.Login(command);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {


                return BadRequest(new { message = "Please Enter Your PhoneNumber Correctly" });
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> AddUser(AddUserCommand command)
        {
            var result = await _csmService.AddUser(command);
            return Ok(result);
        }

        [HttpPost("AddFinance")]
        public async Task<IActionResult> AddFinance(AddFinanceCommand command)
        {
            var result = await _csmService.AddFinance(command);
            return Ok(result);
        }

        [HttpGet("{userId}/Finances/{financeId}")]
        public async Task<IActionResult> GetbyId(Guid userId,Guid financeId)
        {

            var result = await _csmService.GetbyId(Id);
            return Ok(result);

        }


    }
}
