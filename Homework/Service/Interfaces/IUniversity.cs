using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface IUniversity
	{
		int Count(Student[] students);
		double AverageAge(Student[] students);
		Student[] FilterStudentsByEmail(Student[] students, string search);
        Student[] FilterStudentsByAddress(Student[] students, string search);
        Student[] Search(Student[] students, string search);
        int SameName(Student[] students);
    }
}