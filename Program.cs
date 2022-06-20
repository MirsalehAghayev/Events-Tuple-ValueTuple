using System;

namespace HomeWorkJun18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Libraryy libray = new Libraryy("Kitablar");
            while (true)
            {
                Console.WriteLine("(1) Kitabxanaya isci elave edin ");
                Console.WriteLine("(2) Muellif elave edin  ");
                Console.WriteLine("(3) Kitabxanaya kitab elave edin ");
                Console.WriteLine("(4) Kitabxanadan isci silin ");
                Console.WriteLine("(5) Kitabxanadan kitab silin ");
                Console.WriteLine("(6) Muellifin kitablarina baxin ");

                string numm = Console.ReadLine();
                bool isInt = int.TryParse(numm, out int menu);
                switch (menu)
                {
                    case 1:

                        Console.WriteLine("Iscinin adi ");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Iscinin soyadi ");
                        string esname = Console.ReadLine();
                    AGE:
                        Console.WriteLine("Iscinin yasi ");
                        string eage = Console.ReadLine();
                        bool isAge = int.TryParse(eage, out int age);
                        if (!isAge)
                        {
                            Console.WriteLine("Yanlis daxil etdiniz, zehmet olmasa duzgun daxil edin ");
                            goto AGE;
                        }
                        Employee employe = new Employee(ename, esname, age);
                        libray.employes.Add(employe);
                        Console.WriteLine($"{ename} adli isciniz elave olundu ");
                        break;
                    case 2:

                        Console.WriteLine("Muellifin adi ");
                        string mname = Console.ReadLine();
                        Console.WriteLine("Muellifin soyadi ");
                        string msname = Console.ReadLine();
                    AGE2:
                        Console.WriteLine("Muellifin yasi ");
                        string mage = Console.ReadLine();
                        bool ismAge = int.TryParse(mage, out int _mage);

                        if (!ismAge)
                        {
                            Console.WriteLine("Yanlis daxil etdiniz, zehmet olmasa duzgun daxil edin ");
                            goto AGE2;
                        }
                        Author author = new Author(mname, msname, _mage);
                        libray.authors.Add(author);
                        Console.WriteLine($"{mname} adli muellif elave olundu ");
                        break;

                }

            }
        }
    }
}
