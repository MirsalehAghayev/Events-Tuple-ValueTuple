using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkJun18
{
    internal class Books
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Id { get; }
        public static int _id;
        public List<Author> authors;

        public Books()
        {

        }
        public Books(string name, int year) : this()
        {
            Name = name;
            Year = year;
            Id = ++_id;
            authors = new List<Author>();

        }
    }
}
