using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_debugging_example
{
    class Student
    {
        string Name;
        string idNamber;
        Department department;

        public Student(string idNamber, string name, Department department)
        {
            this.idNamber = idNamber;
            this.Name = name;
            this.department = department;
        }
        public string ToString()
        {
            return
                "<" + this.Name + ">" + " -" + " <" + this.idNamber + ">" + " -" + "< " +
            this.department.Title_ + ">";

        }



    }
}
