using System;


namespace _1.Models
{
    public class CartInfo
    {
        public CartInfo(string cartnumber, string cvv2, string expiredatemonth, string expiredateyear, decimal balance, string deposit)
        {
            ID = Guid.NewGuid();
            CartNumber = cartnumber;
            Cvv2 = cvv2;
            ExpireDateMonth = expiredatemonth;
            Balance = balance;
            Deposit = deposit;
            ExpireDateYear = expiredateyear;
        }

        public Guid ID { get; set; }
        public string CartNumber { get; set; }
        public string Cvv2 { get; set; }
        public string ExpireDateYear { get; set; }
        public string ExpireDateMonth { get; set; }

        /// <summary>
        /// موجودی
        /// </summary>
        public decimal Balance { get; set; }


        public string Deposit { get; set; }

        /// <summary>
        /// For ORM
        /// </summary>
        private CartInfo()
        {
        }

    }
}
