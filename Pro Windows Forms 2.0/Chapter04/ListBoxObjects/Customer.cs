using System;
using System.Collections.Generic;
using System.Text;

namespace ListBoxObjects
{
	public class Customer
	{
		public string FirstName;
		public string LastName;
		public DateTime BirthDate;

		public Customer() { }

		public Customer(string firstName, string lastName, DateTime birthDate)
		{
			FirstName = firstName;
			LastName = lastName;
			BirthDate = birthDate;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}

}
