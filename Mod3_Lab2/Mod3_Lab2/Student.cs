using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
	public class Student : Person
	{
		public Student(string name, int age) : base(name, age)
		{
			this.Grade = 75;
			_studentCount++;
		}

		private static int _studentCount;
		private int _grade;

		public int Grade
		{
			get
			{
				return _grade;
			}

			set
			{
				_grade = value;
			}
		}

		public static int CountStudents()
		{
			return _studentCount;
		}
	}
}
