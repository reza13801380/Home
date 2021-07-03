using _1.Commands;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1.Dtos;
using _1.Dto;

namespace _1.Service
{
    public interface ICsmService
    {
        Task<User> Login(LoginUserCommand command);
        Task<bool> AddUser(AddUserCommand command);
        Task<bool> AddCart(AddCartCommand command);
        Task<bool> AddFinance(AddFinanceCommand command);
        Task<FinanceDto> GetbyId(Guid Id);
        Task<bool> AddProfileImage(MyFile myFile);
        //Task<CartInfoDtos> GetAllCarts();
    }
}
