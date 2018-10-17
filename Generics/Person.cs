using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Person: IComparable<Person>
    {
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            // Implement how we are going to compare two people
            // Since all we have is age, we will need to use that

            if (Age < other.Age)
            {
                return -1;
            }
            else if (Age == other.Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
