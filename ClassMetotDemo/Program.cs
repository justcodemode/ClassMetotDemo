using System;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Sıla";
			int age = 23;

			Customer customer1 = new Customer();
			customer1.CustomerName = "James";
			customer1.Age = 32;
			customer1.Id = "1234567891011";

			Customer customer2 = new Customer();
			customer2.CustomerName = "Olivia";
			customer2.Age = 35;
			customer2.Id = "1234567891012";

			Customer customer3 = new Customer();
			customer3.CustomerName = "Watson";
			customer3.Age = 57;
			customer3.Id = "1234567891013";

			Customer[] customers = new Customer[] { customer1, customer2, customer3 };

			foreach (var customer in customers)
			{
				Console.WriteLine(customer.CustomerName + " : " + customer.Id + "  " + customer.Age);
			}


			Console.WriteLine("Hello World!");

		}
	}
	class Customer
	{
		public string CustomerName { get; set; }
		public int Age { get; set; }
		public string Id { get; set; }
	}


}

