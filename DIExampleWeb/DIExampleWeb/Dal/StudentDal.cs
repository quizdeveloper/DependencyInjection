using DIExampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIExampleWeb.Dal
{
    public class StudentDal : IStudentDal
    {
        private static List<Student> lstStudent = new List<Student>() {
               new Student(){ Id = 1, Email ="test1@gmail.com", FullName ="Test 1" },
               new Student(){ Id = 2, Email ="test2@gmail.com", FullName ="Test 2" },
               new Student(){ Id = 3, Email ="test3@gmail.com", FullName ="Test 3" },
               new Student(){ Id = 4, Email ="test4@gmail.com", FullName ="Test 4" }
            };

        public List<Student> GetAll()
        {
            return lstStudent;
        }

        public Student GetById(int id)
        {
            return lstStudent.FirstOrDefault(x => x.Id == id);
        }

        public Student GetByName(string name)
        {
           return lstStudent.FirstOrDefault(x => x.FullName.Equals(name));
        }
    }
}
