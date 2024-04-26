using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Rectangle
    {
        public Rectangle() { }

        public void CalcRectanglePerimeter()
        {
            Console.Write("Dikdörtgenin uzun kenarını giriniz:");
            int longSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin kısa kenarını giriniz:");
            int shortSide = Convert.ToInt32(Console.ReadLine());

            int result = longSide + shortSide;
            Console.WriteLine($"Dikdörtgenin çevresi: {result}");
        }
        public void CalcRectangleArea()
        {
            Console.Write("Dikdörtgenin uzun kenarını giriniz:");
            int longSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin kısa kenarını giriniz:");
            int shortSide = Convert.ToInt32(Console.ReadLine());

            int result = longSide * shortSide;
            Console.WriteLine($"Dikdörtgenin alanı: {result}");
        }
    }
}
