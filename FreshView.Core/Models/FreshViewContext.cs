using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FreshView.Core.Models
{
    public partial class FreshViewContext : DbContext
    {
        public FreshViewContext()
        {
        }

        public FreshViewContext(DbContextOptions<FreshViewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Competence> Competence { get; set; }
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<CompetitionCourse> CompetitionCourse { get; set; }
        public virtual DbSet<CompetitionStudent> CompetitionStudent { get; set; }
        public virtual DbSet<CompetitionTeacher> CompetitionTeacher { get; set; }
        public virtual DbSet<Competitions> Competitions { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseStudyCompetence> CourseStudyCompetence { get; set; }
        public virtual DbSet<CourseStudyGroup> CourseStudyGroup { get; set; }
        public virtual DbSet<CourseTeacher> CourseTeacher { get; set; }
        public virtual DbSet<CourseType> CourseType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentTeacher> DepartmentTeacher { get; set; }
        public virtual DbSet<EducationalProgram> EducationalProgram { get; set; }
        public virtual DbSet<EducationalProgramCourse> EducationalProgramCourse { get; set; }
        public virtual DbSet<ExternalMember> ExternalMember { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<GradeType> GradeType { get; set; }
        public virtual DbSet<PartnersTask> PartnersTask { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<ScientificWork> ScientificWork { get; set; }
        public virtual DbSet<ScientificWorkTeacher> ScientificWorkTeacher { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentCompetition> StudentCompetition { get; set; }
        public virtual DbSet<StudyGroup> StudyGroup { get; set; }
        public virtual DbSet<StudyGroupStudent> StudyGroupStudent { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherCompetition> TeacherCompetition { get; set; }
        public virtual DbSet<TeacherCourse> TeacherCourse { get; set; }
        public virtual DbSet<TeacherScientificWork> TeacherScientificWork { get; set; }
        public virtual DbSet<TeachersCategory> TeachersCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=localhost;Database=FreshView;Username=postgres;Password=1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CompetitionDate).HasDefaultValueSql("now()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<CompetitionCourse>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CompetitionId, e.CourseId })
                    .HasName("CompetitionCourse_CompetitionId_CourseId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competition)
                    .WithMany()
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionCourse_Competition");

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionCourse_Course");
            });

            modelBuilder.Entity<CompetitionStudent>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CompetitionId, e.StudentId })
                    .HasName("CompetitionStudent_CompetitionId_StudentId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competition)
                    .WithMany()
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionTeacher_Competition");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionTeacher_Teacher");
            });

            modelBuilder.Entity<CompetitionTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CompetitionId, e.TeacherId })
                    .HasName("CompetitionTeacher_CompetitionId_TeacherId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competition)
                    .WithMany()
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionTeacher_Competition");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetitionTeacher_Teacher");
            });

            modelBuilder.Entity<Competitions>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CompetencyLevelIncrease).HasColumnType("numeric");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CourseTypeNavigation)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.CourseType)
                    .HasConstraintName("FK_Course_CourseType");

                entity.HasOne(d => d.EducationalProgramNavigation)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.EducationalProgram)
                    .HasConstraintName("FK_Course_EducationalProgram");

                entity.HasOne(d => d.SpecialityNavigation)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.Speciality)
                    .HasConstraintName("FK_Course_Speciality");
            });

            modelBuilder.Entity<CourseStudyCompetence>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CourseId, e.CompetenceId })
                    .HasName("CourseStudyCompetence_CourseId_CompetenceId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competence)
                    .WithMany()
                    .HasForeignKey(d => d.CompetenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudyCompetence_Competence");

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudyCompetence_Course");
            });

            modelBuilder.Entity<CourseStudyGroup>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CourseId, e.StudyGroupId })
                    .HasName("CourseStudyGroup_CourseId_StudyGroupId_key")
                    .IsUnique();

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudyCompetence_Course");

                entity.HasOne(d => d.StudyGroup)
                    .WithMany()
                    .HasForeignKey(d => d.StudyGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCourseStudyCompetence_StudyGroup");
            });

            modelBuilder.Entity<CourseTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.CourseId, e.TeacherId })
                    .HasName("CourseTeacher_CourseId_TeacherId_key")
                    .IsUnique();

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTeacher_Course");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTeacher_Teacher");
            });

            modelBuilder.Entity<CourseType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DepartmentTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.DepartmentId, e.TeacherId })
                    .HasName("DepartmentTeacher_DepartmentId_TeacherId_key")
                    .IsUnique();

                entity.HasOne(d => d.Department)
                    .WithMany()
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentTeacher_Department");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentTeacher_Teacher");
            });

            modelBuilder.Entity<EducationalProgram>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ProgramsCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.StandartsDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<EducationalProgramCourse>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.EducationalProgramId, e.CourseId })
                    .HasName("EducationalProgramCourse_EducationalProgramId_CourseId_key")
                    .IsUnique();

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalProgramCourse_Course");

                entity.HasOne(d => d.EducationalProgram)
                    .WithMany()
                    .HasForeignKey(d => d.EducationalProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalProgramCourse_EducationalProgram");
            });

            modelBuilder.Entity<ExternalMember>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.IsInTopHundred)
                    .IsRequired()
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Secondname)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Value).HasColumnType("numeric");

                entity.HasOne(d => d.GradeTypeNavigation)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.GradeType)
                    .HasConstraintName("FK_Grade_GradeType");

                entity.HasOne(d => d.SpecialityNavigation)
                    .WithMany(p => p.Grade)
                    .HasForeignKey(d => d.Speciality)
                    .HasConstraintName("FK_Grade_Speciality");
            });

            modelBuilder.Entity<GradeType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Review)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");
            });

            modelBuilder.Entity<PartnersTask>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.PartnersTask)
                    .HasForeignKey(d => d.Company)
                    .HasConstraintName("FK_PartnersTask_Company");

                entity.HasOne(d => d.TaskTypeNavigation)
                    .WithMany(p => p.PartnersTask)
                    .HasForeignKey(d => d.TaskType)
                    .HasConstraintName("FK_PartnersTask_TaskType");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ScientificWork>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Annotation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''::character varying");

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.ScientificWork)
                    .HasForeignKey(d => d.Course)
                    .HasConstraintName("FK_ScientificWork_Course");
            });

            modelBuilder.Entity<ScientificWorkTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.ScientificWorkId, e.TeacherId })
                    .HasName("ScientificWorkTeacher_ScientificWorkId_TeacherId_key")
                    .IsUnique();

                entity.HasOne(d => d.ScientificWork)
                    .WithMany()
                    .HasForeignKey(d => d.ScientificWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScientificWorkTeacher_ScientificWork");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScientificWorkTeacher_Teacher");
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AverageSalary).HasColumnType("numeric");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.VacansiesCountHh).HasColumnName("VacansiesCountHH");

                entity.HasOne(d => d.EducationalProgramNavigation)
                    .WithMany(p => p.Speciality)
                    .HasForeignKey(d => d.EducationalProgram)
                    .HasConstraintName("FK_Speciality_EducationalProgram");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_Student_Department");

                entity.HasOne(d => d.SpecialityNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.Speciality)
                    .HasConstraintName("FK_Student_Speciality");

                entity.HasOne(d => d.StudyGroupNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.StudyGroup)
                    .HasConstraintName("FK_Student_StudyGroup");
            });

            modelBuilder.Entity<StudentCompetition>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.StudentId, e.CompetitionId })
                    .HasName("StudentCompetition_StudentId_CompetitionId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competition)
                    .WithMany()
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCompetition_Competition");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentCompetition_Student");
            });

            modelBuilder.Entity<StudyGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StudyGroupStudent>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.StudyGroupId, e.StudentId })
                    .HasName("StudyGroupStudent_StudyGroupId_StudentId_key")
                    .IsUnique();

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyGroupStudent_Student");

                entity.HasOne(d => d.StudyGroup)
                    .WithMany()
                    .HasForeignKey(d => d.StudyGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudyGroupStudent_StudyGroup");
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.AcademicDegree)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AcademicRank)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ExternalWorkAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Hindex)
                    .HasColumnName("HIndex")
                    .HasColumnType("numeric");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.University)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_Teacher_Department");

                entity.HasOne(d => d.TeachersCategoryNavigation)
                    .WithMany(p => p.Teacher)
                    .HasForeignKey(d => d.TeachersCategory)
                    .HasConstraintName("FK_Teacher_TeachersCategory");
            });

            modelBuilder.Entity<TeacherCompetition>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.TeacherId, e.CompetitionId })
                    .HasName("TeacherCompetition_TeacherId_CompetitionId_key")
                    .IsUnique();

                entity.HasOne(d => d.Competition)
                    .WithMany()
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCompetition_Competition");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCompetition_Teacher");
            });

            modelBuilder.Entity<TeacherCourse>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.TeacherId, e.CourseId })
                    .HasName("TeacherCourse_TeacherId_CourseId_key")
                    .IsUnique();

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCourse_Course");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherCourse_Teacher");
            });

            modelBuilder.Entity<TeacherScientificWork>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => new { e.TeacherId, e.ScientificWorkId })
                    .HasName("TeacherScientificWork_TeacherId_ScientificWorkId_key")
                    .IsUnique();

                entity.HasOne(d => d.ScientificWork)
                    .WithMany()
                    .HasForeignKey(d => d.ScientificWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherScientificWork_ScientificWorkId");

                entity.HasOne(d => d.Teacher)
                    .WithMany()
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherScientificWork_Teacher");
            });

            modelBuilder.Entity<TeachersCategory>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
