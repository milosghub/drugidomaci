using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace csharp_debugging_example
{
    class Student
    {
        string Name;
        string IdNumber;
        Department Department;

        public Student (string name, string Idnumber, Department department)
        {
            this.Name = name;
            this.IdNumber = Idnumber;
            this.Department = Department;

            Public string toString()
            {
                return "<" +this.Name+ ">" + "-" + "<" + this.IdNumber+ ">" + "-" + "<" +this.Department+ ">";
            }
        }
    }
}
