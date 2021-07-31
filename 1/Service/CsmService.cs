using _1.Commands;
using _1.Models;
using _1.Repository;
using _1.UserCommandMapper;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using _1.Dto;
using _1.Mappers;
using _1.Dtos;
using System.Linq;
using System.Collections.Generic;

namespace _1.Service
{
    public class CsmService : ICsmService
    {
        private readonly ICsmRepository _csmRepository;

        public CsmService(ICsmRepository csmRepository)
        {
            _csmRepository = csmRepository;
        }

        public async Task<User> Login(LoginUserCommand command)
        {
            var User = await _csmRepository.Login(command.CellPhone);
            if (User != null)
            {
                User.VerifyCode = new Random().Next(1000, 9999).ToString();
            }
            else
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            return (User);
        }

        public async Task<bool> AddUser(AddUserCommand command)
        {
            return await _csmRepository.AddUser(command.ToModel());
        }

        public async Task<bool> AddCart(AddCartCommand command)
        {
            return await _csmRepository.AddCart(command.ToModel());
        }

        public async Task<bool> AddFinance(AddFinanceCommand command)
        {
            return await _csmRepository.AddFinance(command.ToModel());
        }


        public async Task<FinanceDto> GetbyId(Guid Id)
        {
            var result = await _csmRepository.GetbyId(Id);
            return result.ToDto();
        }
        public async Task<bool> EditFinance(EditFinanceCommand command)
        {
            var update = await _csmRepository.GetbyId(command.ID);
            update.Price = command.Price;
            update.Title = command.Title;
            update.assetclassification = command.assetclassification;
            update.Date = command.Date;
            update.Description = command.Description;
            return await _csmRepository.Update();
        }
        public async Task <List<FinanceDto>> GetAll()
        {
            var result= await _csmRepository.GetAll();
            return result.ToDto();
        }
        public async Task<bool> DeleteFinance(DeleteFinanceCommand command)
        {
            var result = await _csmRepository.GetbyId(command.ID);
            return await _csmRepository.DeleteFinance(result);

        }
        public async Task<bool> PhoneNumberInquiry(string CellPhone)
        {
            return await _csmRepository.PhoneNumberInquiry(CellPhone);
        }
        public async Task<User> GetById(Guid Id)
        {
            return await _csmRepository.GetById(Id);
        }
        public async Task<bool> EditUser(UpdateUserCommand command)
        {
            var user = await _csmRepository.GetById(command.id);
            user.Address = command.Address;
            user.BirthDate = command.BirthDate;
            user.gender = command.gender;
            user.CellPhone = command.CellPhone;
            user.NationalCode = command.NationalCode;
            user.Phone = command.phone;
            user.FullName = command.FullName;
            return await _csmRepository.Update();
        }
        public async Task<CartInfo> GetCardById(Guid id)
        {
            return await _csmRepository.GetCardById(id);
        }
        public async Task<bool> EditCart(UpdateCartCommand command)
        {
            var Cart = await _csmRepository.GetCardById(command.ID);
            Cart.Cvv2 = command.Cvv2;
            Cart.ExpireDateYear = command.ExpireDateYear;
            Cart.ExpireDateMonth = command.ExpireDateMonth;
            Cart.CartNumber = command.CartNumber;
            return await _csmRepository.Update();

        }

        public async Task<bool> AddProfileImage(MyFile myFile)
        {
            var result = await _csmRepository.AddProfileImage(myFile);
            return result;
        }
        public async Task<List<CartInfoDtos>> GetAllCart()
        {
            var result = await _csmRepository.GetAllCart();
            return result.ToDto();
        }

        public async Task<bool> AddTransaction(AddTransactionCommand command)
        {
            return await _csmRepository.AddTransaction(command.ToModel());
        }

        public async Task<TransactionDto> GetTransactionbyId(Guid Id)
        {
            var result = await _csmRepository.GetTransactionbyId(Id);
            return result.TonewDto();
        }

        public async Task<bool> EditTransaction(EditTransactionCommand command)
        {
            var update = await _csmRepository.GetTransactionbyId(command.ID);
            update.ID = command.ID;
            update.Price = command.Price;
            update.Title = command.Title;
            update.transaction_Classification = command.transaction_Classification;
            update.type = command.type;
            update.Description = command.Description;
            update.Date = command.Date;
            update.CartID = command.CartID;
            return await _csmRepository.Update();
        }

        public async Task<List<TransactionDto>> GetAllTransaction()
        {
            var result = await _csmRepository.GetAllTransaction();
            return result.ToDto();
        }

        public async Task<bool> DeleteTransaction(DeleteTransactionCommand command)
        {
            var result = await _csmRepository.GetTransactionbyId(command.ID);
            return await _csmRepository.DeleteTransaction(result);
        }
    }


}

