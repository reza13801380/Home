using _1.Commands;
using _1.Dtos;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Repository
{
    public interface ICsmRepository
    {
        Task<User> Login(string cellphone);
        Task<bool> AddUser(User user);
        Task<bool> AddCart(CartInfo command);
        Task<bool> AddFinance(Finance finance);
        Task<Finance> GetbyId(Guid Id);
        Task<bool> AddProfileImage(MyFile myFile);
        Task<bool> PhoneNumberInquiry(string CellPhone);
        Task<User> GetById(Guid Id);
        Task<bool> Update();
        Task<CartInfo> GetCardById(Guid id);
        Task<List<Finance>> GetAll();
        Task<bool> DeleteFinance(Finance finance);
        Task<List<CartInfo>> GetAllCart();
        Task<bool> AddTransaction(FinancialTransaction financialTransaction);
        Task<FinancialTransaction> GetTransactionbyId(Guid Id);
        Task<List<FinancialTransaction>> GetAllTransaction();
        Task<bool> DeleteTransaction(FinancialTransaction financialTransaction);


    }
}
