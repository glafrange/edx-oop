using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
	public class Teacher : Person
	{
		public Teacher(string name, int age) : base(name, age)
		{

		}

		private int _gradesGiven = 0;

		public int GradesGiven
		{
			get
			{
				return _gradesGiven;
			}
		}

		public void GiveGrade(int grade, Student student)
		{
			student.Grade = grade;
			_gradesGiven++;
		}
	}
}
