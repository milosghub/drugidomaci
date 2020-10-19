using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_debugging_example
{
    class Department
    {
        string Title;
        string Code;
        public Department(string code)
        {
            if (code.Equals("IT"))
                Title = "Informacione tehnologije";
            else if (code.Equals("RI")
                Title = "Racunarska tehnika";
                
        }
    }
}
