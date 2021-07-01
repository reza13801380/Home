using _1.Enums;
using _1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Commands
{
    public class AddUserCommand
    {
        public string FullName { get; set; }
        public Gender gender { get; set; }
        public string NationalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public string phone { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
        public List<AddCartCommand> cartInfos { get; set; }
    }
}
