using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkJun18
{
    internal class Libraryy
    {
        public string Name { get; set; }
        public List<Employee> employes;
        public List<Books> books;
        public List<Author> authors;
        public Libraryy(string name)
        {
            Name = name;
            employes = new List<Employee>();
            books = new List<Books>();
            authors = new List<Author>();

        }
    }
}



