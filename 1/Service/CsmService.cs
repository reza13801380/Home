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

        public async Task<bool> AddProfileImage(MyFile myFile)
        {
            var result = await _csmRepository.AddProfileImage(myFile);
            return result;
        }
        //public async Task<CartInfoDtos> GetAllCarts()
        //{
        //    await _csmRepository.GetAllCarts(CartInfoDtos.ToModel()):
        //    return Dtos;

        //}
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

        public async Task<List<CartInfoDtos>> GetAllCarts(Guid id)
        {
            var result = await _csmRepository.GetById(id);
            var Cart = result.Cartinfo.Select(x => new CartInfoDtos
            {
                CartNumber = x.CartNumber,
                Cvv2 = x.Cvv2,
                ExpireDateMonth = x.ExpireDateMonth,
                ExpireDateYear = x.ExpireDateYear
            });
            return Cart.ToList();

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

    }


}

