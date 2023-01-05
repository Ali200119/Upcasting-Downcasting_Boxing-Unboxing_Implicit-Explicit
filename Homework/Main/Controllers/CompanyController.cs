using System;
using Domain.Models;
using Service;
using Service.Interfaces;

namespace Main.Controllers
{
	public class CompanyController
	{
		private readonly ICompany _company;

		public CompanyController()
		{
			_company = new Company();
		}

		public void Show()
		{
			Console.WriteLine($"Count of employees: {_company.Count(GetEmployee(), new DateTime(1993, 01, 01), new DateTime(2008, 01, 01), 2000)}");
		}

		private Employee[] GetEmployee()
		{
			Employee employee1 = new Employee("Ali", "Talibov", new DateTime(2001, 08, 19), 2500);
            Employee employee2 = new Employee("Cavid", "Bashirov", new DateTime(1993, 04, 17), 3500);
            Employee employee3 = new Employee("Scott", "Reynolds", new DateTime(1990, 06, 12), 2000);
            Employee employee4 = new Employee("Bethany", "Francis", new DateTime(1997, 01, 07), 2100);

			return new Employee[] {employee1, employee2, employee3, employee4};
        }
	}
}

