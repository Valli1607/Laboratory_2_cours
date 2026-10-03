using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_3
{
    internal class Dialog
    {
        private WorkArray arr;
        private WorkString str;
        public Dialog()
        {
            arr = new WorkArray();
            str = new WorkString();
        }
        public void StartDialog()
        {
            Console.WriteLine("Hello, checking user!!!");
            Console.WriteLine("Your list of commands: ");
            Console.WriteLine("1 - Working with arrays");
            Console.WriteLine("2 - Working with strings");
            Console.WriteLine("e - exit from Program");
            bool isContinue = true;
            while (isContinue)
            {
                Console.Write("Enter your choise: ");
                char sym;
                while (!char.TryParse(Console.ReadLine(), out sym))
                {
                    Console.WriteLine("Enter again:");
                }
                switch (sym)
                {
                    case '1': FirstTask(); break;
                    case '2': SecondTask(); break;
                    case 'e': isContinue = false; Console.WriteLine("Good byu"); break;
                    default: Console.WriteLine("Incorrect command"); break;
                }
            }
        }
        void FirstTask()
        {
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
            while (isContinue)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "ia1":
                        {
                            this.arr.InitOrdinArray();
                            break;
                        }
                    case "ia2":
                        {
                            this.arr.InitRagArray();
                            break;
                        }
                    case "iar1":
                        {
                            this.arr.InitOrdinArrayRandom();
                            break;
                        }
                    case "iar2":
                        {
                            this.arr.InitRagArrayRandom();
                            break;
                        }
                    case "p":
                        {
                            this.arr.Print();
                            break;
                        }
                    case "add":
                        {
                            this.arr.AddRow();
                            break;
                        }
                    case "del":
                        {
                            this.arr.DeleteZero();
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
        void SecondTask()
        {
            Console.WriteLine("Your list of commands for work with strings: ");
            Console.WriteLine("init - initialization a string");
            Console.WriteLine("initR - initialization a random string");
            Console.WriteLine("p - print string");
            Console.WriteLine("edit - edit string (task for work with string");
            Console.WriteLine("e - exit");
            bool isContinue = true;
            while (isContinue)
            {
                Console.Write("Enter command: ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "init":
                        {
                            this.str.InitString();
                            break;
                        }
                    case "initR":
                        {
                            this.str.InitTestingString();
                            break;
                        }
                    case "p":
                        {
                            this.str.Print();
                            break;
                        }
                    case "edit":
                        {
                            this.str.Edit();
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
    }
}
