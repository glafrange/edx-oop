using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
	public abstract class Person : IDisposable
	{
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}

		private bool Disposed = false;
		private string _name;
		private int _age;

		StreamWriter streamWriterObject;

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

		public bool WriteDetails()
		{
			bool result = false;
			streamWriterObject = new StreamWriter("output.txt", append: true);

			try
			{
				using (streamWriterObject)
				{
					streamWriterObject.WriteLine("{0}, {1}", this.Name, this.Age);
				}
				result = true;
			}

			catch(Exception e)
			{
				Console.WriteLine("This file could not be written");
				Console.WriteLine(e.Message);
				result = false;
			}

			finally
			{
				streamWriterObject.Close();
				streamWriterObject = null;
			}

			return result;
		}

		~Person()
		{
			this.Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!Disposed)
			{
				if (disposing)
				{
					if (streamWriterObject != null)
					{
						streamWriterObject.Close();
					}
				}
			}

			Disposed = true;
		}
		
	}
}
