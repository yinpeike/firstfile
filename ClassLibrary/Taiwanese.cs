using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Taiwanese : IPerson
    {
        public string Name { get; set; }

        public Taiwanese(string name)
        {
            this.Name = name;
        }

        public int Age { get; set; }

        public String Nationality
        {
            get
            {                
                return "中華台北";
            }
        }

        
        public bool Married(int age)
        {
            age = this.Age;

            if (Name.StartsWith("阿"))
            {
                if (age >= 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (age >= 30)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
