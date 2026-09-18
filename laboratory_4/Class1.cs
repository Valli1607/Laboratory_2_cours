using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_4
{
    internal class Point
    {
        private double x;
        private double y;
        public static int count = 0;
        public Point()
        {
            this.x = 0;
            this.y = 0;
            count++;
        }
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Dist(Point point)
        {
            return Math.Pow(Math.Pow(point.x - this.x, 2) + Math.Pow(point.y - this.y, 2), 0.5);
        }
        public void Print()
        {
            Console.WriteLine($"x = {this.x}, y = {this.y}");
        }
        public void Print(Point point)
        {
            Console.WriteLine($"x = { point.x}, y = {point.y}");
        }
        public static Point operator ++(Point p1)
        {
            ++p1.x;
            return p1;
        }
        public static Point operator --(Point p1)
        {
            --p1.x;
            return p1;
        }
        public static explicit operator int(Point p)
        {
            return (int)p.x;
        }
        public static implicit operator double(Point p)
        {
            return p.y;
        }
        public static double operator +(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        public static Point operator +(Point p1, int value)
        {
            return new Point(p1.x + value, p1.y);
        }
        public static Point operator +(int value,Point p1)
        {
            return new Point(p1.x + value, p1.y);
        }
    }
}
