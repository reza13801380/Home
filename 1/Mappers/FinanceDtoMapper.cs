using _1.Dto;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Mappers
{
    public static class FinanceDtoMapper
    {
        public static FinanceDto ToDto(this Finance finance)
        {
            return new FinanceDto
            {
                ID=finance.ID,
                assetclassification=finance.assetclassification,
                CartID=finance.CartID,
                Date=finance.Date,
                Description=finance.Description,
                Price=finance.Price,
                Title=finance.Title,
            };
        }
        public static List<FinanceDto> ToDto(this List<Finance> finance)
        {
            var result = finance.Select(x => new FinanceDto{ assetclassification = x.assetclassification , Date=x.Date, Description=x.Description, Title=x.Title, Price=x.Price, ID=x.ID  }).ToList();
            return result;
        }    

        

    }
}
