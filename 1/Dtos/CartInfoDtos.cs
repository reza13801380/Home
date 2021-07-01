using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Dtos
{
    public class CartInfoDtos
    {
        public Guid ID { get; set; }
        public string CartNumber { get; set; }
        public string Cvv2 { get; set; }
        public string ExpireDateYear { get; set; }
        public string ExpireDateMonth { get; set; }
        public string Balance { get; set; }
        public string Deposit { get; set; }
    }
}
