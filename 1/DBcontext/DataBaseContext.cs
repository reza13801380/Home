using _1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.DBcontext
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<CartInfo> CartInfos { get; set; }
        public DbSet<Finance> finances { get; set; }
        public DbSet<FinancialTransaction> financialTransactions { get; set; }
    }
}
