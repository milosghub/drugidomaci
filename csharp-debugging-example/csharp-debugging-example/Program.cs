using System;
using System.Collections.Generic;

namespace csharp_debugging_example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listaStudenata = new LinkedList<Student>()
            {
            new Student("1", "Milan Novakovic", new Department("ri"));
            new Student("2", "Nikola Milanovic", new Department("it"));
            new Student("3", "Milos Milosevic", new Department("it"));

            for (int i = 0; i < listaStudenata.Count; i++)
                Console.WriteLine(listaStudenata[1].ToString);
            }
        }
    }
}
