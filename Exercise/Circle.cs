using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Circle
    {
        public int Radius { get; set; }

        public double Pi { get; set; } = 3.14;

        public Circle() 
        { 

        }

        public void CalcCircleCircumference()
        {
            Console.Write("Lütfen üçgenin yarıçapını giriniz:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double result = 2*radius * Pi;
            Console.WriteLine(result);
        }
        public void CalcCircleArea()
        {
            Console.Write("Lütfen üçgenin yarıçapını giriniz:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double result = Math.Pow(radius,2) * Pi;
            Console.WriteLine(result);
        }

    }
}
