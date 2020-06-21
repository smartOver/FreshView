using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
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
            FreshViewContext context = app.ApplicationServices.GetRequiredService<FreshViewContext>();
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
                Department = department.Id
            };

            context.EducationalProgram.Add(eProgram);
            context.Course.Add(course);
            context.Teacher.Add(teacher);

            department.Teacher.Add(teacher);
            ///course.Teacher.Add(teacher);
            eProgram.Course.Add(course);
        }
    }
}
