using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
	public class Student : Person
	{
		public Student(string name, int age) : base(name, age)
		{
			this.Grade = 75;
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
