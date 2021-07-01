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
    }
}
