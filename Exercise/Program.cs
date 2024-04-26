using System.Reflection;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Lütfen alanını hesaplamak istediğiniz şekli giriniz:");
            Console.WriteLine("1. Daire");
            Console.WriteLine("2. Kare");
            Console.WriteLine("3. Üçgen");
            Console.WriteLine("4. Dikdörtgen");
            Console.WriteLine("*********************");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hesaplanmak istediğiniz boyutu seçiniz:");
            Console.WriteLine("1. Çevre:");
            Console.WriteLine("2. Alan:");
            string input = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    if (input == "1")
                    {
                        circle.CalcCircleCircumference();
                    }
                    else if (input == "2")
                    {
                        circle.CalcCircleArea();
                    } 
                    break;
                case 2:
                    if (input == "1")
                    {
                        square.CalcSquarePerimeter();
                    }
                    else if (input == "2")
                    {
                        square.CalcSquareArea();
                    }
                    break;
                case 3:
                    if (input == "1")
                    {
                        triangle.CalcTrianglePerimeter();
                    }
                    else if (input == "2")
                    {
                        triangle.CalcTriangleArea();
                    }
                    break;
                case 4:
                    if (input == "1")
                    {
                        rectangle.CalcRectanglePerimeter(); 
                    }
                    else if (input == "2")
                    {
                        rectangle.CalcRectangleArea();
                    }
                    break;
            }


        }
    }
}
