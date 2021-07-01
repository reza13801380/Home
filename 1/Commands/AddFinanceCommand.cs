using _1.Enums;
using System;


namespace _1.Commands
{
    public class AddFinanceCommand
    {
        
        public Assetclassification assetclassification { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CartID { get; set; }
    }
}
