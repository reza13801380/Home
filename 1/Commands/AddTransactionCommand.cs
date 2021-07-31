using _1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Commands
{
    public class AddTransactionCommand
    {
        public Guid ID { get; set; }
        public type type { get; set; }
        public Transaction_classification transaction_Classification { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CartID { get; set; }
    }
}
