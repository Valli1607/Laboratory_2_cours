using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_3
{
    internal class WorkArray
    {
        private int[,] arr1;
        private int[][] arr2;
        public WorkArray()
        {
            arr1 = null;
            arr2 = null;
        }
        private int InputSize(string prompt)
        {
            int size;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out size) && size > 0)
                    return size;
                Console.WriteLine("Error, enter a positive number");
            }
        }
        public void InitOrdinArray()
        {
            int strings = InputSize("Enter number of rows: ");
            int columns = InputSize("Enter number of cols: ");
            this.arr1 = new int[strings, columns];
            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < strings; i++)
            {
                string[] input = InputElements(columns);
                for (int j = 0; j < columns; j++)
                {
                    this.arr1[i, j] = int.Parse(input[j]);
                }
            }
            this.arr2 = null;
        }
        public void InitOrdinArrayRandom()
        {
            Random rnd = new Random();
            int strings = InputSize("Enter number of rows: ");
            int columns = InputSize("Enter number of cols: ");
            this.arr1 = new int[strings, columns];
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.arr1[i, j] = rnd.Next(0, 100);
                }
            }
            this.arr2 = null;
        }
        public void InitRagArray()
        {
            int strings = InputSize("Enter number of rows: ");
            this.arr2 = new int[strings][];
            for (int i = 0; i < strings; i++)
            {
                int columns = InputSize("Enter number of cols: ");
                string[] input = InputElements(columns);
                this.arr2[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    this.arr2[i][j] = int.Parse(input[j]);
                }
                Console.WriteLine();
            }
            this.arr1 = null;
        }
        public void InitRagArrayRandom()
        {
            Random rnd = new Random();
            int strings = InputSize("Enter number of rows: ");
            this.arr2 = new int[strings][];
            for (int i = 0; i < strings; i++)
            {
                int columns = InputSize("Enter number of cols: ");
                this.arr2[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    this.arr2[i][j] = rnd.Next(0, 100);
                }
                Console.WriteLine();
            }
            this.arr1 = null;
        }
        public void Print()
        {
            if (this.arr1 != null)
            {
                PrintArray(this.arr1);
            }
            else if (this.arr2 != null)
            {
                PrintArray(this.arr2);
            }
            else
            {
                Console.WriteLine("Array is empty");
            }
        }
        private void PrintArray(int[,] arr1)
        {
            if (arr1 == null) { Console.WriteLine("Your array is empty"); return; }
            Console.WriteLine("Resulting array: ");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private void PrintArray(int[][] arr2)
        {
            if (arr2 == null) { Console.WriteLine("Your array is empty"); return; }
            Console.WriteLine("Resulting array: ");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void AddRow()
        {
            Random rnd = new Random();
            Console.Write("Do you want to enter new elements?[y/n]: ");
            char sym;
            while (!char.TryParse(Console.ReadLine(), out sym))
            {
                Console.WriteLine("Enter again:");
            }
            if (this.arr1 == null)
            {
                Console.WriteLine("Incorrect array");
                return;
            }
            int[,] arr;
            if (sym == 'y')
            {

                arr = (int[,])this.arr1.Clone();
                Console.WriteLine("Enter new elements of array: ");
                for (int i = this.arr1.GetLength(0); i < this.arr1.GetLength(0) + 1; i++)
                {
                    string[] input = InputElements(this.arr1.GetLength(1));
                    for (int j = 0; j < this.arr1.GetLength(1); j++)
                    {
                        arr[i, j] = int.Parse(input[j]);
                    }
                }
            }
            else if (sym == 'n')
            {
                arr = (int[,])this.arr1.Clone();
                for (int i = this.arr1.GetLength(0); i < this.arr1.GetLength(0) + 1; i++)
                {
                    for (int j = 0; j < this.arr1.GetLength(1); j++)
                    {
                        arr[i, j] = rnd.Next(1, 100);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, incorrect input");
                return;
            }
            this.arr1 = (int[,])arr.Clone();
        }
        public void DeleteZero()
        {
            if (this.arr2 == null) { Console.WriteLine("Your array is empty"); return; }
            int newstr = 0;
            for (int i = 0; i < this.arr2.Length; i++)
            {
                bool isZero = false;
                for (int j = 0; j < this.arr2[i].Length; j++)
                {
                    if (this.arr2[i][j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (!isZero)
                {
                    newstr++;
                }
            }
            int[][] res = new int[newstr][];
            int ind = 0;
            for (int i = 0; i < this.arr2.Length; i++)
            {
                bool isZero = false;
                for (int j = 0; j < this.arr2[i].Length; j++)
                {
                    if (this.arr2[i][j] == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (!isZero)
                {
                    res[ind] = this.arr2[i];
                    ind++;
                }
            }
            this.arr2 = res;
        }
        private string[] InputElements(int columns)
        {
            while (true)
            {
                Console.Write("Enter elements: ");
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == columns)
                    return input;

                Console.WriteLine("Incorrect number of elements. Enter again:");
            }
        }
    }
}
