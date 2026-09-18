using System;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        StartDialog();
    }
    static void StartDialog()
    {
        Console.WriteLine("Hello, checking user!!!");
        Console.WriteLine("Your list of commands: ");
        Console.WriteLine("1 - Working with arrays");
        Console.WriteLine("2 - Working with strings");
        Console.WriteLine("e - exit from Program");
        bool isContinue = true;
        while (isContinue) {
            Console.Write("Enter your choise: ");
            char sym = char.Parse(Console.ReadLine());
            switch (sym)
            {
                case '1': FirstTask(); break;
                case '2': SecondTask(); break;
                case 'e': isContinue = false;  Console.WriteLine("Good byu"); break;
                default: Console.WriteLine("Incorrect command"); break;
            }
        }
    }
        static void FirstTask()
    {
        int[,] arr1= null;
        int[][] arr2=null;
        bool isContinue = true;

        Console.WriteLine("Your list of commands for work with arrays: ");
        Console.WriteLine("ia1 - initialization of ordinary array");
        Console.WriteLine("ia2 - initialization a ragged array");
        Console.WriteLine("iar1 - initialization an ordinary array with random numbers");
        Console.WriteLine("iar2 - initialization a ragged array with random numbers");
        Console.WriteLine("p - print array");
        Console.WriteLine("add - first task of array");
        Console.WriteLine("del - second tack of array");
        Console.WriteLine("e - exit");
        Console.WriteLine("Enter your choise");
        while(isContinue){
            Console.Write("Enter command: ");
            string command = Console.ReadLine();
            switch (command)
            {
                case "ia1":
                    {
                        arr1 = null;
                        arr1 = InitOrdinArray();
                        arr2 = null;
                        break;
                    }
                case "ia2":
                    {
                        arr2 = null;
                        arr2 = InitRagArray();
                        arr1 = null;
                        break;
                    }
                case "iar1":
                    {

                        arr1 = null;
                        arr1 = InitOrdinArrayRandom();
                        arr2 = null;
                        break;
                    }
                case "iar2":
                    {
                        arr2 = null;
                        arr2 = InitRagArrayRandom();
                        arr1 = null;
                        break;
                    }
                case "p":
                    {
                        if (arr1 != null)
                        {
                            PrintArray(arr1);
                        }
                        else if (arr2 != null)
                        {
                            PrintArray(arr2);
                        }
                        else
                        {
                            Console.WriteLine("Array is empty");
                        }
                        break;
                    }
                case "add":
                    {
                        if (arr1 != null)
                        {
                            AddRow(ref arr1);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect array");
                        }
                        break;
                    }
                case "del":
                    {
                        if (arr2 != null)
                        {
                            DeleteZero(ref arr2);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect array");
                        }
                        break;
                    }
                case "e":
                    {
                        isContinue = false;
                        break;
                    }
                default: Console.WriteLine("Incorrect command"); break;
            }
        }
    }
    static void SecondTask()
    {
        Console.WriteLine("Your list of commands for work with strings: ");
        Console.WriteLine("init - initialization a string");
        Console.WriteLine("initR - initialization a random string");
        Console.WriteLine("p - print string");
        Console.WriteLine("edit - edit string (task for work with string");
        Console.WriteLine("e - exit");
        string str=null;
        bool isContinue = true;
        while (isContinue) {
            Console.Write("Enter command: ");
            string command = Console.ReadLine();
            switch (command)
            {
                case "init":
                    {
                        str = null;
                        str = InitString();
                        break;
                    }
                case "initR":
                    {
                        str = null;
                        int num;
                        Console.Write("Choose number an random string(1:4): ");
                        num = int.Parse(Console.ReadLine());
                        while (num <= 0)
                        {
                            Console.Write("Incorrect input. Enter number: ");
                            num = int.Parse(Console.ReadLine());
                        }
                        if (num == 1)
                        {
                            str = InitTestingString()[0];
                        }
                        else if (num == 2)
                        {
                            str = InitTestingString()[1];
                        }
                        else if (num == 3)
                        {
                            str = InitTestingString()[2];
                        }
                        else if (num == 4)
                        {
                            str = InitTestingString()[3];
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }
                        break;
                    }
                case "p":
                    {
                        PrintString(str);
                        break;
                    }
                case "edit":
                    {
                        if (str != null)
                        {
                            EditString(ref str);
                        }
                        else
                        {
                            Console.WriteLine("String is empty");
                        }
                            break;
                    }
                case "e":
                    {
                        isContinue = false;
                        break;
                    }
                default: Console.WriteLine("Incorrect input"); break;
            }

        }
    }
    static int InputSize(string prompt)
    {
        Console.Write(prompt);
        int size;
        while (!int.TryParse(Console.ReadLine(),out size) || size <= 0)
        {
            Console.WriteLine("Error, enter a positive number");
        }
        return size;
    }
    static string InitString() {
        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();
        return str;

    }
    static string[] InitTestingString()
    {
        string[] str = { "_value __hidden _max_length counter_x normal", "abc12345 xyz98765 qq 1abc", "ab abcdef abcdefgh", "123 4567 89" };
        return str;
    }

    static int[,] InitOrdinArray()
    { 
        int strings = InputSize("Enter number of rows: ");
        int columns = InputSize("Enter number of cols: ");
        int[,] arr = new int[strings, columns];
        Console.WriteLine("Enter elements of array: ");
        for (int i = 0; i < strings; i++)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }
        return arr;
    }
    static int[,] InitOrdinArrayRandom()
    {
        Random rnd = new Random();
        int strings = InputSize("Enter number of rows: ");
        int columns = InputSize("Enter number of cols: ");
        int[,] arr = new int[strings, columns];
        for (int i = 0; i < strings; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = rnd.Next(0, 100);
            }
        }
        return arr;
    }
    static int[][] InitRagArray()
    {
        int strings = InputSize("Enter number of rows: ");
        int[][] arr = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            int columns = InputSize("Enter number of cols: ");
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            arr[i] = new int[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                arr[i][j] = int.Parse(input[j]);
            }
            Console.WriteLine();
        }
        return arr;
    }
    static int[][] InitRagArrayRandom()
    {
        Random rnd = new Random();
        int strings = InputSize("Enter number of rows: ");
        int[][] arr = new int[strings][];
        for (int i = 0; i < strings; i++)
        {
            int columns = InputSize("Enter number of cols: ");
            arr[i] = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                arr[i][j] = rnd.Next(0,100);
            }
            Console.WriteLine();
        }
        return arr;
    }
    static void PrintArray(int[,] arr)
    {
        if (arr==null) { Console.WriteLine("Your array is empty"); return; }
        Console.WriteLine("Resulting array: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void PrintString(string str)
    {
        if (str==null) { Console.WriteLine("Your string is empty"); return; }
        Console.WriteLine("Resulting string: ");
        Console.WriteLine($"{str}");
    }
    static void PrintArray(int[][] arr)
    {
        if (arr==null) { Console.WriteLine("Your array is empty"); return; }
        Console.WriteLine("Resulting array: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j]+"\t");
            }
            Console.WriteLine();
        }
    }
    static void AddRow(ref int[,] arr)
    {
        Random rnd = new Random();
        Console.Write("Do you want to enter new elements?[y/n]: ");
        char sym = char.Parse(Console.ReadLine());
        int[,] arr1 = null;
        if (sym == 'y')
        {

            arr1 = new int[arr.GetLength(0) + 1, arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] = arr[i, j];
                }
            }
            Console.WriteLine("Enter new elements of array: ");
            for (int i = arr.GetLength(0); i < arr.GetLength(0) + 1; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] = int.Parse(input[j]);
                }
            }
        }
        else if (sym == 'n')
        {
            arr1 = new int[arr.GetLength(0) + 1, arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] = arr[i, j];
                }
            }
            for (int i = arr.GetLength(0); i < arr.GetLength(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(1,100);
                }
            }
        }
        else
        {
            Console.WriteLine("Error, incorrect input");
            return;
        }
        arr = arr1;
    }
    static void EditString(ref string str)
    {
        if (str == null) { Console.WriteLine("Your string is empty"); return; }
        string word = "";
        string str1 = "";
        for(int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if(c!=' ')
            {
                word += c;
            }
            else
            {
                if(word.Length>0 && (char.IsLetter(word[0]) || word[0] == '_'))
                {
                    str1 += word+" ";
                }
                word = "";
            }
            
        }
        if (word.Length > 0 && (char.IsLetter(word[0]) || word[0] == '_'))
            str1 += word +" ";
        word = "";
        if (str1.Length == 0) { Console.WriteLine("Identificators is absent"); return; }
        int max = 0;
        Console.WriteLine("Resulting list of max identificator: ");
        for(int i = 0; i < str1.Length; i++)
        {
            char c = str1[i];
            if (char.IsLetterOrDigit(c) || c == '_')
            {
                word += c;
            }
            else
            {
                if (max < word.Length) max = word.Length;
                word = "";
            }
        }
        if (max < word.Length) max = word.Length;
        word = "";
        for (int i = 0; i < str1.Length; i++)
        {
            char c = str1[i];
            if (char.IsLetterOrDigit(c) || c == '_')
            {
                word += c;
            }
            else
            {
                if (max == word.Length)
                {
                    Console.WriteLine($"{word}");
                }
                word = "";
            }
        }
        if (word.Length > 0 && max == word.Length)
            Console.WriteLine(word);

    }
    static void DeleteZero(ref int[][] arr)
    {
        if (arr==null) { Console.WriteLine("Your array is empty"); return; }
        int newstr = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            bool isZero = false;
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == 0)
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
        for(int i = 0; i < arr.Length; i++)
        {
            bool isZero = false;
            for(int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] == 0)
                {
                    isZero = true;
                    break;
                }
            }
            if (!isZero)
            {
                res[ind] = arr[i];
                ind++;
            }
        }
        arr = res;
    }
}