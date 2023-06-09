using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{

    public class UserController : BaseApiController
    {
       private readonly  DataContext _context ;

        public UserController(DataContext dataContext)
        {
            _context = dataContext;
        }
         
         [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
            return await _context.Users.ToListAsync();
        }
        [HttpGet("id")]
        public async Task<ActionResult<AppUser>> GetUser(int id ){
            return await _context.Users.FindAsync(id);
        }
    }
}