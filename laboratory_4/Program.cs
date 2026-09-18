using System;
using System.Drawing;
namespace laboratory_4
{
    internal class Program
    {
        static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point(3, 4);
            Point p3 = new Point(6, 8);
            Console.Write("Enter x: ");
            double x, y;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Error!");
            }
            Console.Write("Enter y: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Error!");
            }
            Point p4 = new Point(x, y);
            Console.WriteLine("Точка 1:");
            p1.Print();
            Console.WriteLine("Точка 2:");
            p2.Print();
            Console.WriteLine("Точка 3:");
            p3.Print();
            Console.WriteLine("Точка 4:");
            p4.Print();
            Console.WriteLine($"p1 → p2: {p1.Dist(p2):F4}");
            Console.WriteLine($"p1 → p3: {p1.Dist(p3):F4}");
            Console.WriteLine($"p2 → p3: {p2.Dist(p3):F4}");
            Console.WriteLine($"p3 → p4: {Dist(p3, p4):F4}");
            Console.WriteLine($"p2 → p4: {Dist(p2, p4):F4}");
            p1.X = 10;
            p1.Y = 20;
            p1.Print();
        }
        static double Dist(Point point1,Point point2)
        {
            return Math.Pow(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2), 0.5);
        }
        static void RemotePoint(PointArr arr)
        {
            double max = 0;
            Point p = new Point(0, 0);
            for(int i = 0; i < arr.Size; i++)
            {
                if (Math.Abs(arr[i].Dist(p)) > max)
                {
                    max = Math.Abs(arr[i].Dist(p));
                }
            }
            for(int i = 0; i < arr.Size; i++)
            {
                if(Math.Abs(arr[i].Dist(p)) == max)
                {
                    arr[i].Print();
                }
            }
        }
    }
}