using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Square
    {
        public int Size { get; set; }

        public Square() { }

        public void CalcSquareArea()
        {
            Console.Write("Karenin kenar uzunluğunu giriniz:");
            int size = Convert.ToInt32(Console.ReadLine());
            double result = size * size;
            Console.WriteLine(result);
        }
        public void CalcSquarePerimeter()
        {
            Console.Write("Karenin kenar uzunluğunu giriniz:");
            int size = Convert.ToInt32(Console.ReadLine());
            double result = 4 * size;
            Console.WriteLine(result);
        }


    }
}
