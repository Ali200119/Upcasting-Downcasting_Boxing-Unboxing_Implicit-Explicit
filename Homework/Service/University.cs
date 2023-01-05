using System;
using Domain.Models;
using Service.Interfaces;

namespace Service
{
    public class University : IUniversity
    {
        public double AverageAge(Student[] students)
        {
            double sum = 0;

            foreach (Student student in students)
            {
                sum += student.Age;
            }

            return sum / students.Length;
        }

        public int Count(Student[] students)
        {
            return students.Length;
        }

        public Student[] FilterStudentsByAddress(Student[] students, string search)
        {
            Student[] newStudents = new Student[students.Length];

            for (int i = 0; i < newStudents.Length; i++)
            {
                if (students[i].Address.ToLower() == search.ToLower())
                {
                    newStudents[i] = students[i];
                }
            }

            return newStudents;
        }

        public Student[] FilterStudentsByEmail(Student[] students, string search)
        {
            Student[] newStudents = new Student[students.Length];

            for (int i = 0; i < newStudents.Length; i++)
            {
                if (students[i].Email.StartsWith(search.ToLower()))
                {
                    newStudents[i] = students[i];
                }
            }

            return newStudents;
        }

        public int SameName(Student[] students)
        {
            int count = 0;

            for (int j = 0; j < students.Length - 1; j++)
            {
                for (int i = 0; i < students.Length - 1; i++)
                {
                    if (students[i].Name == students[i + 1].Name)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public Student[] Search(Student[] students, string search)
        {
            Student[] newStudents = new Student[students.Length];

            for (int i = 0; i < newStudents.Length; i++)
            {
                if (search.Trim().ToLower() == students[i].Name.ToLower() || search.Trim().ToLower() == students[i].Surname.ToLower())
                {
                    newStudents[i] = students[i];
                }
            }

            return newStudents;
        }
    }
}