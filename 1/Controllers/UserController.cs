﻿using _1.Commands;
using _1.Models;
using _1.Repository;
using _1.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
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

        //[HttpGet("{userId}/Finances/{financeId}")]
        //public async Task<IActionResult> GetbyId(Guid userId, Guid financeId)
        //{

        //    var result = await _csmService.GetbyId(Id);
        //    return Ok(result);

        //}
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            var fileName = FileNameGenerator(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileName);
            var myFile = new MyFile(file.FileName, path)
            {
                Size = file.Length
            };
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var result = await _csmService.AddProfileImage(myFile);
            if (result == true)
            {
                return Ok(new { fileid = myFile.Id });
            }
            else
            {
                return Ok(new { type = "error" });
            }

        }
        private string FileNameGenerator(string fileName)
        {
            string constName = $"{fileName}HomeManagement";

            var random = new Random();
            var randomNumber = random.Next(50, 5000000).ToString();

            var fileNameArray = fileName.Split('.');

            return constName + randomNumber + "." + fileNameArray[1];
        }
      
        [HttpPut("{Id}/EditFinance")]
        public async Task<IActionResult> EditFinance(Guid id ,EditFinanceCommand command)
        {
            command.ID= id;
            var result = await _csmService.EditFinance(command);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _csmService.GetAll();
            return Ok(result);

        }
        [HttpDelete("DeleteFinance")]
        public async Task<IActionResult> DeleteFinance(DeleteFinanceCommand command)
        {
            var result = await _csmService.DeleteFinance(command);
            return Ok(result);
        }


        [HttpPut("{Id}/Update-User")]
        public async Task<IActionResult> EditUserInformation(Guid id, UpdateUserCommand command)

        
        {
            var agar = await _csmService.PhoneNumberInquiry(command.CellPhone);
            if (agar == true)
            {
                return Ok(new { type = "error", User = "exist" });
            }
            else
            {
                command.id = id;
                var result = await _csmService.EditUser(command);
                return Ok(new { type = "success" });
            }


        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var result = await _csmService.GetById(Id);
            return Ok(result);
        }
    }
}