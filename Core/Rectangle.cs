using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1.Core
{
    internal class Rectangle : Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Площадь прямоугольника - 15м2");
            return 0;
        }
    }
}
