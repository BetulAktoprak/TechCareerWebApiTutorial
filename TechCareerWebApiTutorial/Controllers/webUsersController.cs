﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerWebApiTutorial.Models.ORM;

namespace TechCareerWebApiTutorial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class webUsersController : ControllerBase
    {
        TechCareerDbContext _context;

        public webUsersController()
        {
            _context = new TechCareerDbContext();
        }


        [HttpGet]
        public IActionResult Get()
        {
            var orders = _context.Orders.Include(x => x.webUsers).ToList();
            return Ok(orders);
        }
    }
}
