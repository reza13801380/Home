using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Commands
{
    public class UpdateCartCommand
    {
        public Guid ID { get; set; }
        public string CartNumber { get; set; }
        public string Cvv2 { get; set; }
        public string ExpireDateYear { get; set; }
        public string ExpireDateMonth { get; set; }
    }
}
