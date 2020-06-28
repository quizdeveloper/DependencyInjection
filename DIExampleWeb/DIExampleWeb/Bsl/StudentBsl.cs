using DIExampleWeb.Dal;
using DIExampleWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExampleWeb.Bsl
{
    public class StudentBsl : IStudentBsl
    {
        private IStudentDal _studentDal;

        public StudentBsl(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public List<Student> GetAll()
        {
           return _studentDal.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public Student GetByName(string name)
        {
            return _studentDal.GetByName(name);
        }
    }
}
