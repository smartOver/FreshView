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
    [Route("[controller]")]
    [ApiController]
    public class EducationalProgramController
    {
        private FreshViewContext context;
        public EducationalProgramController(FreshViewContext ctx) => context = ctx;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationalProgram>>> Get() => await context.EducationalProgram.ToListAsync();
    }
}
