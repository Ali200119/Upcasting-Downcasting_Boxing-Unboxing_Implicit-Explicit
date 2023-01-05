using System;
namespace Domain.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public string Email { get; set; }
		public string Education { get; set; }
		public string Address { get; set; }

		public Student(int id, string name, string surname, int age, string email, string education, string address)
		{
			Id = id;
			Name = name;
			Surname = surname;
			Age = age;
			Email = email;
			Education = education;
			Address = address;
		}

        public override string ToString()
        {
			return $"{Name} {Surname} {Age} {Email} {Education} {Address}";
        }
    }
}