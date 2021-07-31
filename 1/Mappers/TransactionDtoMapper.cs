using _1.Dto;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Mappers
{
    public static class TransactionDtoMapper
    {
        public static TransactionDto TonewDto(this FinancialTransaction financialTransaction)
        {
            return new TransactionDto
            {
                ID = financialTransaction.ID,
                
                Date = financialTransaction.Date,
                Description = financialTransaction.Description,
                Price = financialTransaction.Price,
                Title = financialTransaction.Title,
                transaction_Classification = financialTransaction.transaction_Classification,
                type = financialTransaction.type,
            };
        }
        public static List<TransactionDto> ToDto(this List<FinancialTransaction> financialTransactions )
        {
            var result = financialTransactions.Select(x => new TransactionDto
            {
                
                Date=x.Date,
                Description=x.Description,
                ID=x.ID,
                Price=x.Price,
                Title=x.Title,
                transaction_Classification=x.transaction_Classification,
                type=x.type
            }).ToList();
            return result;

        }
    }
}
