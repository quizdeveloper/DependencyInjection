using DIExampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIExampleWeb.Dal
{
    public interface IStudentDal
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
    }
}
