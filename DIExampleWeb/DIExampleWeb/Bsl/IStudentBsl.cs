using DIExampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleWeb.Bsl
{
    public interface IStudentBsl
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
    }
}
