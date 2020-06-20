using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            var eProgram = new EducationalProgram()
            {
                ProgramsCode = "09.03.02",
                Name = "Информационные системы и технологии",
                Description = "Готовим программистов."
            };

            var course = new Course()
            {
                Name = "Web технологии",
                Description = "К концу курса студент сможет сверстать сайтик за еду."
            };

            var department = new Department()
            {
                Name = "Компьютерных технологий"
            };

            var teacher = new Teacher()
            {
                LastName = "Куликова",
                SecondName = "Николавена",
                Name = "Наталья",
                Position = "Преподаватель",
                Department = department
            };
            department.Teachers.Add(teacher);

            course.Teachers.Add(teacher);
            eProgram.Courses.Add(course);

            context.EducationalPrograms.Add(eProgram);
            context.Courses.Add(course);
            context.Teachers.Add(teacher);
        }
    }
}
