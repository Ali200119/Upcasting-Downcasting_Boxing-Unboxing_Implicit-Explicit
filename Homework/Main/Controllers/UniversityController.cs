using System;
using Domain.Models;
using Service;
using Service.Interfaces;

namespace Main.Controllers
{
	public class UniversityController
	{
		private readonly IUniversity _university;

		public UniversityController()
		{
			_university = new University();
		}

		public void Show()
		{
			string letter = "m";
			string address = "Ehmedli";
			string search = "Talibov";

			Console.WriteLine($"1) Count of students: {_university.Count(GetStudents())}");
			Console.WriteLine($"2) Average of students' age: {_university.AverageAge(GetStudents())}");
            Console.WriteLine($"3) Emails starting with the letter '{letter}':");

			foreach (Student student in _university.FilterStudentsByEmail(GetStudents(), letter))
			{
				if (student != null)
				{
					Console.WriteLine(student);
				}
			}

			Console.WriteLine("----------");

            Console.WriteLine($"4) Students living in {address}:");


            foreach (Student student in _university.FilterStudentsByAddress(GetStudents(), address))
            {
                if (student != null)
                {
                    Console.WriteLine(student);
                }
            }

            Console.WriteLine("----------");

            Console.WriteLine($"5) Search students by {search}:");


            foreach (Student student in _university.Search(GetStudents(), search))
            {
                if (student != null)
                {
                    Console.WriteLine(student);
                }
            }
        }

		private Student[] GetStudents()
		{
			Student student1 = new Student(1, "Ali", "Talibov", 21, "talibov.ali2001@mail.ru", "IT", "Xetai");
            Student student2 = new Student(2, "Jordan", "Lee", 23, "lee.jordan1999@mail.ru", "Accountant", "Ehmedli");
            Student student3 = new Student(3, "James", "Perry", 19, "perry.james2003@mail.ru", "Engineering", "Neftchilar");
            Student student4 = new Student(4, "James", "Mullen", 21, "mullen.james2001@mail.ru", "Design", "Nariman Narimanov");
            Student student5 = new Student(5, "Amelie", "Wilson", 25, "wilson.amelie1997@mail.ru", "Architect", "Sahil");

			return new Student[] { student1, student2, student3, student4, student5 };
        }
	}
}

