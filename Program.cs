using AbstractPractice1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetArea();

            Cicle cicle = new Cicle();
            cicle.GetArea();

            Car car = new Car();
            car.StartEngine();

            Motocycle motocycle = new Motocycle();
            motocycle.StartEngine();
        }
    }
}
