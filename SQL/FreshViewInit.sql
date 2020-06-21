DROP DATABASE IF EXISTS FreshView;
CREATE DATABASE FreshView;

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

DROP TABLE IF EXISTS public."TaskType" CASCADE;
CREATE TABLE public."TaskType" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_TaskType" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Company" CASCADE;
CREATE TABLE public."Company" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Address" varchar(255) NOT NULL DEFAULT '',
	CONSTRAINT "PK_Company" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Competence" CASCADE;
CREATE TABLE public."Competence" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Code" varchar(255) NOT NULL DEFAULT '',
	"Description" varchar(255) NOT NULL DEFAULT '',
	CONSTRAINT "PK_Competence" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."CourseType" CASCADE;
CREATE TABLE public."CourseType" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_CourseType" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."ExternalMember" CASCADE;
CREATE TABLE public."ExternalMember" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Lastname" varchar(255) NOT NULL,
	"Secondname" varchar(255) NOT NULL,
	"Name" varchar(255) NOT NULL,
	"CompanyName" varchar(255) NOT NULL DEFAULT '',
	"Position" varchar(255) NOT NULL DEFAULT '',
	"IsInTopHundred" boolean NOT NULL DEFAULT true,
	CONSTRAINT "PK_ExternalMember" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."TeachersCategory" CASCADE;
CREATE TABLE public."TeachersCategory" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_TeachersCategory" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Region" CASCADE;
CREATE TABLE public."Region" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_Region" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Competition" CASCADE;
CREATE TABLE public."Competition" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"CompetitionDate" timestamp NOT NULL DEFAULT NOW(),
	"City" varchar(255) NOT NULL DEFAULT '',
	"Subject" varchar(255) NOT NULL DEFAULT '',
	CONSTRAINT "PK_Competition" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Department" CASCADE;
CREATE TABLE public."Department" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_Department" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."GradeType" CASCADE;
CREATE TABLE public."GradeType" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Description" varchar(255) NOT NULL DEFAULT '',
	"Review" varchar(255) NOT NULL DEFAULT '',
	CONSTRAINT "PK_GradeType" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."StudyGroup" CASCADE;
CREATE TABLE public."StudyGroup" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	CONSTRAINT "PK_StudyGroup" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."EducationalProgram" CASCADE;
CREATE TABLE public."EducationalProgram" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"ProgramsCode" varchar(100) NOT NULL DEFAULT '',
	"Description" varchar(255) NOT NULL DEFAULT '',
	"StandartsDescription" varchar(255) NOT NULL DEFAULT '',
	"StatusIndicator" integer NOT NULL DEFAULT 0,
	CONSTRAINT "PK_EducationalProgram" PRIMARY KEY ("Id")
);

DROP TABLE IF EXISTS public."Speciality" CASCADE;
CREATE TABLE public."Speciality" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"EducationalProgram" uuid,
	"VacansiesCountHH" integer NOT NULL,
	"AverageSalary" decimal NOT NULL,
	"VacansiesCountInRegion" integer NOT NULL,
	"AverageSalaryInRegion" integer NOT NULL,
	CONSTRAINT "PK_Speciality" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Speciality_EducationalProgram" FOREIGN KEY ("EducationalProgram") REFERENCES "EducationalProgram"("Id")
);

DROP TABLE IF EXISTS public."Teacher" CASCADE;
CREATE TABLE public."Teacher" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"LastName" varchar(255) NOT NULL,
	"SecondName" varchar(255) NOT NULL,
	"Name" varchar(255) NOT NULL,
	"University" varchar(255) NOT NULL,
	"Position" varchar(255) NOT NULL,
	"WorkExperience" integer NOT NULL,
	"WorkExperienceInSpeciality" integer NOT NULL,
	"IsExternalWork" boolean NOT NULL,
	"PartTimeWorkExperience" integer NOT NULL,
	"AcademicDegree" varchar(255) NOT NULL,
	"AcademicRank" varchar(255) NOT NULL,
	"WorksCountPerYear" integer NOT NULL,
	"HIndex" decimal NOT NULL,
	"ExternalWorkAddress" varchar(255) NOT NULL,
	"Comment" varchar(255) NOT NULL,
	"Company" varchar(255) NOT NULL,
	"Department" uuid,
	"TeachersCategory" uuid,
	CONSTRAINT "PK_Teacher" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Teacher_Department" FOREIGN KEY ("Department") REFERENCES "Department"("Id"),
	CONSTRAINT "FK_Teacher_TeachersCategory" FOREIGN KEY ("TeachersCategory") REFERENCES "TeachersCategory"("Id")
);

DROP TABLE IF EXISTS public."Student" CASCADE;
CREATE TABLE public."Student" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"LastName" varchar(255) NOT NULL,
	"SecondName" varchar(255) NOT NULL,
	"Name" varchar(255) NOT NULL,
	"Rating" integer NOT NULL,
	"Department" uuid,
	"StudyGroup" uuid,
	"Speciality" uuid,
	CONSTRAINT "PK_Student" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Student_Department" FOREIGN KEY ("Department") REFERENCES "Department"("Id"),
	CONSTRAINT "FK_Student_StudyGroup" FOREIGN KEY ("StudyGroup") REFERENCES "StudyGroup"("Id"),
	CONSTRAINT "FK_Student_Speciality" FOREIGN KEY ("Speciality") REFERENCES "Speciality"("Id")
);


DROP TABLE IF EXISTS public."Grade" CASCADE;
CREATE TABLE public."Grade" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Value" decimal NOT NULL DEFAULT 0,
	"GradeType" uuid,
	"Teacher" uuid,
	"Student" uuid,
	"Speciality" uuid,
	CONSTRAINT "PK_Grade" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Grade_GradeType" FOREIGN KEY ("GradeType") REFERENCES "GradeType"("Id"),
	CONSTRAINT "FK_Grade_Teacher" FOREIGN KEY ("Teacher") REFERENCES "Teacher"("Id"),
	CONSTRAINT "FK_Grade_Student" FOREIGN KEY ("Student") REFERENCES "Student"("Id"),
	CONSTRAINT "FK_Grade_Speciality" FOREIGN KEY ("Speciality") REFERENCES "Speciality"("Id")
);

DROP TABLE IF EXISTS public."Course" CASCADE;
CREATE TABLE public."Course" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Description" varchar(255) NOT NULL DEFAULT '',
	"CompetencyLevelIncrease" decimal NOT NULL DEFAULT 0,
	"IsExternalMembers" boolean NOT NULL DEFAULT false,
	"StatusIndicator" integer NOT NULL DEFAULT 0,
	"CourseType" uuid,
	"Speciality" uuid,
	"EducationalProgram" uuid,
	CONSTRAINT "PK_Course" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_Course_CourseType" FOREIGN KEY ("CourseType") REFERENCES "CourseType"("Id"),
	CONSTRAINT "FK_Course_Speciality" FOREIGN KEY ("Speciality") REFERENCES "Speciality"("Id"),
	CONSTRAINT "FK_Course_EducationalProgram" FOREIGN KEY ("EducationalProgram") REFERENCES "EducationalProgram"("Id")
);

DROP TABLE IF EXISTS public."PartnersTask" CASCADE;
CREATE TABLE public."PartnersTask" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Course" uuid,
	"Company" uuid,
	"TaskType" uuid,
	CONSTRAINT "PK_PartnersTask" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_PartnersTask_Course" FOREIGN KEY ("Course") REFERENCES "Course"("Id"),
	CONSTRAINT "FK_PartnersTask_Company" FOREIGN KEY ("Company") REFERENCES "Company"("Id"),
	CONSTRAINT "FK_PartnersTask_TaskType" FOREIGN KEY ("TaskType") REFERENCES "TaskType"("Id")
);

DROP TABLE IF EXISTS public."ScientificWork" CASCADE;
CREATE TABLE public."ScientificWork" (
	"Id" uuid NOT NULL DEFAULT uuid_generate_v4() UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Code" varchar(255) NOT NULL DEFAULT '',
	"PublicationDate" timestamp NOT NULL,
	"Subject" varchar(255) NOT NULL DEFAULT '',
	"Keywords" varchar(255) NOT NULL DEFAULT '',
	"Description" varchar(255) NOT NULL DEFAULT '',
	"Annotation" varchar(255) NOT NULL,
	"Course" uuid,
	CONSTRAINT "PK_ScientificWork" PRIMARY KEY ("Id"),
	CONSTRAINT "FK_ScientificWork_Course" FOREIGN KEY ("Course") REFERENCES "Course"("Id")
);

----- CREATE CROSS TABLES ----------------

DROP TABLE IF EXISTS public."CompetitionTeacher" CASCADE;
CREATE TABLE public."CompetitionTeacher" (
	"CompetitionId" uuid NOT NULL,
	"TeacherId" uuid NOT NULL,
	UNIQUE ("CompetitionId", "TeacherId"),
	CONSTRAINT "FK_CompetitionTeacher_Competition" FOREIGN KEY ("CompetitionId") REFERENCES "Competition"("Id"),
	CONSTRAINT "FK_CompetitionTeacher_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id")
);

DROP TABLE IF EXISTS public."CompetitionStudent" CASCADE;
CREATE TABLE public."CompetitionStudent" (
	"CompetitionId" uuid NOT NULL,
	"StudentId" uuid NOT NULL,
	UNIQUE ("CompetitionId", "StudentId"),
	CONSTRAINT "FK_CompetitionTeacher_Competition" FOREIGN KEY ("CompetitionId") REFERENCES "Competition"("Id"),
	CONSTRAINT "FK_CompetitionTeacher_Teacher" FOREIGN KEY ("StudentId") REFERENCES "Student"("Id")
);

DROP TABLE IF EXISTS public."CompetitionCourse" CASCADE;
CREATE TABLE public."CompetitionCourse" (
	"CompetitionId" uuid NOT NULL,
	"CourseId" uuid NOT NULL,
	UNIQUE ("CompetitionId", "CourseId"),
	CONSTRAINT "FK_CompetitionCourse_Competition" FOREIGN KEY ("CompetitionId") REFERENCES "Competition"("Id"),
	CONSTRAINT "FK_CompetitionCourse_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id")
);

DROP TABLE IF EXISTS public."DepartmentTeacher" CASCADE;
CREATE TABLE public."DepartmentTeacher" (
	"DepartmentId" uuid NOT NULL,
	"TeacherId" uuid NOT NULL,
	UNIQUE ("DepartmentId", "TeacherId"),
	CONSTRAINT "FK_DepartmentTeacher_Department" FOREIGN KEY ("DepartmentId") REFERENCES "Department"("Id"),
	CONSTRAINT "FK_DepartmentTeacher_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id")
);

DROP TABLE IF EXISTS public."StudyGroupStudent" CASCADE;
CREATE TABLE public."StudyGroupStudent" (
	"StudyGroupId" uuid NOT NULL,
	"StudentId" uuid NOT NULL,
	UNIQUE ("StudyGroupId", "StudentId"),
	CONSTRAINT "FK_StudyGroupStudent_StudyGroup" FOREIGN KEY ("StudyGroupId") REFERENCES "StudyGroup"("Id"),
	CONSTRAINT "FK_StudyGroupStudent_Student" FOREIGN KEY ("StudentId") REFERENCES "Student"("Id")
);

DROP TABLE IF EXISTS public."EducationalProgramCourse" CASCADE;
CREATE TABLE public."EducationalProgramCourse" (
	"EducationalProgramId" uuid NOT NULL,
	"CourseId" uuid NOT NULL,
	UNIQUE ("EducationalProgramId", "CourseId"),
	CONSTRAINT "FK_EducationalProgramCourse_EducationalProgram" FOREIGN KEY ("EducationalProgramId") REFERENCES "EducationalProgram"("Id"),
	CONSTRAINT "FK_EducationalProgramCourse_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id")
);

DROP TABLE IF EXISTS public."ScientificWorkTeacher" CASCADE;
CREATE TABLE public."ScientificWorkTeacher" (
	"ScientificWorkId" uuid NOT NULL,
	"TeacherId" uuid NOT NULL,
	UNIQUE ("ScientificWorkId", "TeacherId"),
	CONSTRAINT "FK_ScientificWorkTeacher_ScientificWork" FOREIGN KEY ("ScientificWorkId") REFERENCES "ScientificWork"("Id"),
	CONSTRAINT "FK_ScientificWorkTeacher_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id")
);

DROP TABLE IF EXISTS public."CourseTeacher" CASCADE;
CREATE TABLE public."CourseTeacher" (
	"CourseId" uuid NOT NULL,
	"TeacherId" uuid NOT NULL,
	UNIQUE ("CourseId", "TeacherId"),
	CONSTRAINT "FK_CourseTeacher_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id"),
	CONSTRAINT "FK_CourseTeacher_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id")
);

DROP TABLE IF EXISTS public."CourseStudyGroup" CASCADE;
CREATE TABLE public."CourseStudyGroup" (
	"CourseId" uuid NOT NULL,
	"StudyGroupId" uuid NOT NULL,
	UNIQUE ("CourseId", "StudyGroupId"),
	CONSTRAINT "FK_CourseStudyCompetence_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id"),
	CONSTRAINT "FK_CCourseStudyCompetence_StudyGroup" FOREIGN KEY ("StudyGroupId") REFERENCES "StudyGroup"("Id")
);

DROP TABLE IF EXISTS public."CourseStudyCompetence" CASCADE;
CREATE TABLE public."CourseStudyCompetence" (
	"CourseId" uuid NOT NULL,
	"CompetenceId" uuid NOT NULL,
	UNIQUE ("CourseId", "CompetenceId"),
	CONSTRAINT "FK_CourseStudyCompetence_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id"),
	CONSTRAINT "FK_CourseStudyCompetence_Competence" FOREIGN KEY ("CompetenceId") REFERENCES "Competence"("Id")
);

DROP TABLE IF EXISTS public."StudentCompetition" CASCADE;
CREATE TABLE public."StudentCompetition" (
	"StudentId" uuid NOT NULL,
	"CompetitionId" uuid NOT NULL,
	UNIQUE ("StudentId", "CompetitionId"),
	CONSTRAINT "FK_StudentCompetition_Student" FOREIGN KEY ("StudentId") REFERENCES "Student"("Id"),
	CONSTRAINT "FK_StudentCompetition_Competition" FOREIGN KEY ("CompetitionId") REFERENCES "Competition"("Id")
);

DROP TABLE IF EXISTS public."TeacherCourse" CASCADE;
CREATE TABLE public."TeacherCourse" (
	"TeacherId" uuid NOT NULL,
	"CourseId" uuid NOT NULL,
	UNIQUE ("TeacherId", "CourseId"),
	CONSTRAINT "FK_TeacherCourse_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id"),
	CONSTRAINT "FK_TeacherCourse_Course" FOREIGN KEY ("CourseId") REFERENCES "Course"("Id")
);

DROP TABLE IF EXISTS public."TeacherCompetition" CASCADE;
CREATE TABLE public."TeacherCompetition" (
	"TeacherId" uuid NOT NULL,
	"CompetitionId" uuid NOT NULL,
	UNIQUE ("TeacherId", "CompetitionId"),
	CONSTRAINT "FK_TeacherCompetition_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id"),
	CONSTRAINT "FK_TeacherCompetition_Competition" FOREIGN KEY ("CompetitionId") REFERENCES "Competition"("Id")
);

DROP TABLE IF EXISTS public."TeacherScientificWork" CASCADE;
CREATE TABLE public."TeacherScientificWork" (
	"TeacherId" uuid NOT NULL,
	"ScientificWorkId" uuid NOT NULL,
	UNIQUE ("TeacherId", "ScientificWorkId"),
	CONSTRAINT "FK_TeacherScientificWork_Teacher" FOREIGN KEY ("TeacherId") REFERENCES "Teacher"("Id"),
	CONSTRAINT "FK_TeacherScientificWork_ScientificWorkId" FOREIGN KEY ("ScientificWorkId") REFERENCES "ScientificWork"("Id")
);

