using _1.Commands;
using _1.DBcontext;
using _1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1.Repository
{
    public class CsmRepository : BaseRepository , ICsmRepository
    {
        public CsmRepository(DataBaseContext context) : base(context)
        {

        }

        public async Task<bool> AddCart(CartInfo command)
        {

            await _context.CartInfos.AddAsync(command);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddFinance(Finance finance)
        {
            await _context.finances.AddAsync(finance);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddProfileImage(MyFile myFile)
        {
            await _context.myFiles.AddAsync(myFile);
            var result = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<bool> AddUser(User user)
        {
            await _context.User.AddAsync(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async  Task<Finance> GetbyId(Guid Id)
        {
            var finance = await _context.finances.FirstOrDefaultAsync(a => a.ID == Id);
            return finance;
        }

        public async Task<User> Login(string cellphone)
        {
            return await _context.User
                .Include(x => x.Cartinfo)
                .SingleOrDefaultAsync(x => x.CellPhone == cellphone);
                
        }

            
    }
}
