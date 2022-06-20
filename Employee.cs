using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkJun18
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Id { get; }
        public static int _id;


        public Employee()
        {

        }
        public Employee(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Id = ++_id;

        }
    }
}

