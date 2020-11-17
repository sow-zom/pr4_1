using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suck some dick");
            Human x = new Human();
            Abiturient y = new Abiturient();
            Student u = new Student();
            Teacher r = new Teacher();
            Bibl_user k = new Bibl_user();
            x.SET_ALL();
            x.ShowInfo();
            y.SET_ALL();
            y.ShowInfo();
            u.SET_ALL();
            u.ShowInfo();
            r.SET_ALL();
            r.ShowInfo();
            k.SET_ALL();
            k.ShowInfo();
        }
    }
}
