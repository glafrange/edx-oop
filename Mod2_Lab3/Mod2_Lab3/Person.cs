using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab3
{
	public abstract class Person
	{
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		private string _name;
		private int _age;

		public string Name
		{
			get
			{
				return _name;
			}
			
			set
			{
				_name = value;
			}
		}

		public int Age
		{
			get
			{
				return _age;
			}

			set
			{
				_age = value;
			}
		}
	}
}
