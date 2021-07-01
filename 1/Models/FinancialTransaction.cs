using System;
using _1.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Models
{
    public class FinancialTransaction
    {
        public FinancialTransaction(decimal price, string description, Guid cartID, type Type, Transaction_classification transaction_classification, string title, DateTime date)
        {
            ID = Guid.NewGuid();
            CartID = cartID;
            Description = description;
            CartID = cartID;
            type = Type;
            transaction_Classification = transaction_classification;
            Title = title;
            Date = date;
            Price = price;

        }
        public Guid ID { get; set; }
        public type type { get; set; }
        public Transaction_classification transaction_Classification { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CartID { get; set; }
        /// <summary>
        /// FOR ORM
        /// </summary>
        private FinancialTransaction()
        {
        }
    }
}
