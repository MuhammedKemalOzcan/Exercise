using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Triangle
    {
        public Triangle() { }

        public void CalcTrianglePerimeter()
        {
            Console.WriteLine("Üçgenin kenar uzunluklarını giriniz:");
            int side = Convert.ToInt32(Console.ReadLine());
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());

            int result = side + side1 + side2;
            Console.WriteLine(result);
        }
        public void CalcTriangleArea()
        {
            Console.WriteLine("Üçgenin taban alanını giriniz:");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin yüksekliğini giriniz:");
            int height = Convert.ToInt32(Console.ReadLine());

            int result = (taban * height) / 2;
            Console.WriteLine(result);
        }
    }
}
