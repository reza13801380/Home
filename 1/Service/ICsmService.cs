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
        Task<bool> PhoneNumberInquiry(string CellPhone);
        Task<bool> EditUser(UpdateUserCommand command);
        Task<User> GetById(Guid Id);
        Task<CartInfo> GetCardById(Guid id);
        Task<bool> EditCart(UpdateCartCommand command);
        Task<bool> EditFinance(EditFinanceCommand command);
        Task<List<FinanceDto>> GetAll();
        Task<bool> DeleteFinance(DeleteFinanceCommand command);
        Task<List<CartInfoDtos>> GetAllCart();
        Task<bool> AddTransaction(AddTransactionCommand command);
        Task<TransactionDto> GetTransactionbyId(Guid Id);
        Task<bool> EditTransaction(EditTransactionCommand command);
        Task<List<TransactionDto>> GetAllTransaction();
        Task<bool> DeleteTransaction(DeleteTransactionCommand command);



        //Task<CartInfoDtos> GetAllCarts();
    }
}
