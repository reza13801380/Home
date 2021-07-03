using _1.Commands;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.UserCommandMapper
{
    public static class UserCommandMapper
    {
        public static User ToModel(this AddUserCommand command)
        {
            return new User(command.Address, command.BirthDate, command.CellPhone, command.gender, command.phone, command.NationalCode, command.cartInfos.ToModel());

        }
        public static List<CartInfo> ToModel(this List<AddCartCommand> command)
        {
            return command.Select(x => new CartInfo(x.CartNumber, x.Cvv2, x.ExpireDateMonth, x.ExpireDateYear, x.Balance, x.Deposit)).ToList();

        }
        public static CartInfo ToModel(this AddCartCommand command)
        {
            return new CartInfo(command.CartNumber, command.Cvv2, command.ExpireDateMonth, command.ExpireDateYear, command.Balance, command.Deposit);
        }

        public static Finance ToModel(this AddFinanceCommand command)
        {
            return new Finance(command.Price, command.Description, command.CartID, command.assetclassification, command.Title, command.Date);
        }
       

    }
}
