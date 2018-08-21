using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
	class Program
	{
		static void Main(string[] args)
		{
			var uprogram = new UProgram("Information Technology");
			var student1 = new Student("Tim", 24);
			var student2 = new Student("Gabe", 33);
			var student3 = new Student("John", 21);
			var course = new Course("Programming With C#");
			course.Students.Add(student1);
			course.Students.Add(student2);
			course.Students.Add(student3);
			var teacher = new Teacher("Karen", 42);
			teacher.GiveGrade(80, student2);
			course.Teacher = teacher;
			var degree = new Degree("Bachelor");
			degree.Course = course;
			uprogram.Degree = degree;

			Console.WriteLine("This is the {0} Program, which contains the {1} Degree", uprogram.ProgramName, degree.DegreeName);
			Console.WriteLine("The course in the degree is " + course.CourseName);
			Console.WriteLine("There are {0} Students in the course", Student.CountStudents());

			foreach (var student in course.Students)
			{
				student.WriteDetails();
				student.Dispose();
			}

			teacher.WriteDetails();
			teacher.Dispose();
		}
	}

	public class UProgram
	{
		public UProgram(string programName)
		{
			this.ProgramName = programName;
		}

		public Degree Degree { get; set; }
		public string ProgramName { get; set; }
	}

	public class Degree
	{
		public Degree(string degreeName)
		{
			this.DegreeName = degreeName;
		}


		public Course Course { get; set; }
		public string DegreeName { get; set; }
	}

	public class Course
	{
		public Course(string courseName)
		{
			this.CourseName = courseName;
		}

		public string CourseName { get; set; }
		public List<Student> Students = new List<Student>();
		public Teacher Teacher { get; set; }
	}
}