using _1.Commands;
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

    }
}
