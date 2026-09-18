using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_4
{
    internal class PointArr
    {
        private Point[] arr;
        private int size;
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public PointArr()
        {
            arr = new Point[0];
        }
        public PointArr(int size,bool isRandom=false)
        {
            this.size = size;
            this.arr = new Point[size];
            if (isRandom)
            {
                Console.Write("Enter elements of array: ");
                for (int i = 0; i < size; i++)
                {
                    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    while (input.Length < 2)
                    {
                        Console.Write("Error! Enter two numbers of element: ");
                        input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    }
                    this.arr[i] = new Point(double.Parse(input[0]), double.Parse(input[1]));
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    double x =rnd.Next(0,100);
                    double y = rnd.Next(0,100);
                    arr[i] = new Point(x, y);
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("Resulting array: ");
            foreach(Point p in this.arr)
            {
                p.Print();
            }
        }
        public Point this[int index]
        {
            get
            {
                if(index<=0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                return arr[index];
            }
            set
            {
                if (index <= 0 || index >= size)
                {
                    throw new IndexOutOfRangeException();
                }
                arr[index] = value;
            }
        }
    }
}
