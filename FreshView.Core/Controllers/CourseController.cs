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
    public class CourseController : ControllerBase
    {
        private AppDbContext context;
        public CourseController(AppDbContext ctx) => context = ctx;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> Get() => await context.Courses.ToListAsync();
    }
}
