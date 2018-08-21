using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
	abstract class Employee
	{
		// 3 private member variables: employeeName, employeeBaseSalary, and employeeId
		private string employeeName;
		private double employeeBaseSalary;
		private int employeeId;
		
		// Creates integer variable called "employeeCount" and assigns value to 1
		private static int employeeCount = 1;

		// Constructor
		public Employee(String name, double baseSalary)
		{
			this.Name = name;
			this.BaseSalary = baseSalary;
			this.ID = employeeCount++;
		}

		// Public properties
		public string Name
		{
			get
			{
				return employeeName;
			}

			set
			{
				employeeName = value;
			}
		}
		public double BaseSalary
		{
			get
			{
				return employeeBaseSalary;
			}

			set
			{
				employeeBaseSalary = value;
			}
		}
		public int ID
		{
			get
			{
				return employeeId;
			}

			set
			{
				employeeId = value;
			}
		}

		// This method returns the employee's base salary
		public double getBaseSalary()
		{
			return this.BaseSalary;
		}

		// This method returns the employee's name
		public String getName()
		{
			return this.Name;
		}

		// This method returns the employee's ID
		public int getEmployeeID()
		{
			return this.ID;
		}

		// This method returns the employee's ID and Name
		public String toString()
		{
			return this.ID + " " + this.Name;
		}

		// This method returns the employee's ID and Name and confirms that the employee is in the system
		public abstract String employeeStatus();
	}
}
