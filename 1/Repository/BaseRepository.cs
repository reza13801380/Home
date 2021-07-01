using _1.DBcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Repository
{
    public class BaseRepository
    {
        protected readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }
    }
}
