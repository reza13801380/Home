using _1.Commands;
using _1.Models;
using _1.Repository;
using _1.UserCommandMapper;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using _1.Dto;
using _1.Mappers;
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
            if(User !=null)
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

        //public async Task<CartInfoDtos> GetAllCarts()
        //{
        //    await _csmRepository.GetAllCarts(CartInfoDtos.ToModel()):
        //    return Dtos;

        //}
    }

}

