using System;
using System.Collections.Generic;

namespace csharp_debugging_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listaStudenata = new List<Student>() {
             new Student("1", "Milan Novakovic", new Department("RI")), 
             new Student("2", "Nikola Milanovic", new Department("IT")),
             new Student("3", "Milos Milosevic", new Department("IT"))};


            for (int i = 0; i < listaStudenata.Count; ++i)
                Console.WriteLine(listaStudenata[i].ToString());



        }
    }
}
