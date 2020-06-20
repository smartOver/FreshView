using FreshView.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private AppDbContext context;
        public TeacherController(AppDbContext ctx) => context = ctx;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> Get() => await context.Teachers.ToListAsync();
    }
}
