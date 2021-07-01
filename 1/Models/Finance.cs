using _1.Enums;
using System;


namespace _1.Models
{
    public class Finance
    {
        public Finance(decimal price, string description, Guid cartID,Assetclassification assetClassification,string title,DateTime date)
        {
            ID = Guid.NewGuid();
            assetclassification = assetClassification;
            Title = title;
            Date = date;
            Price = price;
            Description = description;
            CartID = cartID;
        }
        public Guid ID { get; set; }
        public Assetclassification assetclassification { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Guid CartID { get; set; }
        private Finance()
        {
        }
    }
    
}
