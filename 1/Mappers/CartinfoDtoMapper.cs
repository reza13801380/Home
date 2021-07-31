using _1.Dtos;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Mappers
{
    public static class CartinfoDtoMapper
    {
        public static List<CartInfoDtos> ToDto(this List<CartInfo> cartInfos)
        {
            var info = cartInfos.Select(x => new CartInfoDtos
            {
                Balance = x.Balance,
                CartNumber = x.CartNumber,
                Deposit = x.Deposit,
                Cvv2 = x.Cvv2,
                ExpireDateMonth = x.ExpireDateMonth,
                ExpireDateYear = x.ExpireDateYear,
                ID = x.ID
            }).ToList();
            return info;
        }
    }
}
