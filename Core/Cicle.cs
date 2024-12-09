using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1.Core
{
    internal class Cicle : Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Площадь круга 10м2");
            return 0;
        }
    }
}
