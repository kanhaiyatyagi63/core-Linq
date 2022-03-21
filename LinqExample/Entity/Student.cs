using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample.Entity
{
    public class Student : System.Object
    {
        // constructor
        public Student()
        {

        }

        public override string ToString()
        {
            return $"Id: {Id}, RollNumber: {RollNumber}, Name : {Name}, Address: {Address}";
        }

        // auto implemented property
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public string Address { get; set; }

        // non static method for getting student list
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student()
            {
                Id = 1,
                RollNumber = 100,
                Name = "Ravish Rajput",
                Address = "Noida"
            });
            students.Add(new Student()
            {
                Id = 2,
                RollNumber = 110,
                Name = "Praveen Yadav",
                Address = "Jaunpur"
            });
            students.Add(new Student()
            {
                Id = 3,
                RollNumber = 120,
                Name = "Kanhaiya",
                Address = "Muzaffarnagar"
            });
            students.Add(new Student()
            {
                Id = 4,
                RollNumber = 130,
                Name = "Yash",
                Address = "Delhi"
            });
            students.Add(new Student()
            {
                Id = 5,
                RollNumber = 135,
                Name = "Rahul",
                Address = "Noida"
            });
            students.Add(new Student()
            {
                Id = 6,
                RollNumber = 140,
                Name = "Vishal Yadav",
                Address = "Jaunpur"
            });
            return students;
        }
    }
}
