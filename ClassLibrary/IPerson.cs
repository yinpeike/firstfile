using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IPerson
    {
        int Age { get; set; }
        string Name { get; set; }
        string Nationality { get; }
        bool Married(int age);        
    }
}
