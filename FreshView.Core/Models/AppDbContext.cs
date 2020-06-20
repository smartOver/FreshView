using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshView.Core.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Competence> Competencies { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EducationalProgram> EducationalPrograms { get; set; }
        public DbSet<ExternalMember> ExternalMembers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<GradeType> GradeTypes { get; set; }
        public DbSet<PartnersTask> PartnersTasks { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ScientificWork> ScientificWorks { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudyGroup> StudyGroups { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachersCategory> TeachersCategories { get; set; }
    }
}
