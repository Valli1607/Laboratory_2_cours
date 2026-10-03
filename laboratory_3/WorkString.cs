using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace laboratory_3
{
    internal class WorkString
    {
        private string str;
        public WorkString()
        {
            this.str = "";
        }
        public void InitString()
        {
            Console.WriteLine("Enter string: ");
            this.str = Console.ReadLine();

        }
        public void InitTestingString()
        {
            string[] str = { "_value __hidden _max_length counter_x normal", "abc12345 xyz98765 qq 1abc", "ab abcdef abcdefgh", "123 4567 89" };
            int num = InputNumber("Choose number an random string (1:4): ", 1, 4);
            while (num <= 0)
            {
                Console.Write("Incorrect input. Enter number: ");
                num = int.Parse(Console.ReadLine());
            }
            if (num == 1)
            {
                this.str = str[0];
            }
            else if (num == 2)
            {
                this.str = str[1];
            }
            else if (num == 3)
            {
                this.str = str[2];
            }
            else if (num == 4)
            {
                this.str = str[3];
            }
        }
        public void Print()
        {
            if (this.str == null) { Console.WriteLine("Your string is empty"); return; }
            Console.WriteLine("Resulting string: ");
            Console.WriteLine($"{this.str}");
        }
        public void Edit()
        {
            if(this.str == null)
            {
                Console.WriteLine("String is empty");
                return;
            }
            MatchCollection matches = Regex.Matches(this.str, @"(?<![A-Za-z0-9_])[A-Za-z_][A-Za-z0-9_]*");
            if (matches.Count == 0)
            {
                Console.WriteLine("Identificators is absent");
                return;
            }
            int max = 0;
            foreach (Match match in matches)
            {
                if (match.Length > max)
                    max = match.Length;
            }
            Console.WriteLine("Resulting lists with identificator:");
            foreach (Match match in matches)
            {
                if (match.Length == max)
                    Console.WriteLine(match.Value);
            }
        }
        private int InputNumber(string prompt, int min, int max)
        {
            int number;

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out number) &&
                    number >= min && number <= max)
                {
                    return number;
                }

                Console.WriteLine("Incorrect input. Enter again:");
            }
        }
    }
}
//public void Edit()
//{
//    if (this.str == null) { Console.WriteLine("Your string is empty"); return; }
//    string word = "";
//    string str1 = "";
//    for (int i = 0; i < str.Length; i++)
//    {
//        char c = str[i];
//        if (c != ' ')
//        {
//            word += c;
//        }
//        else
//        {
//            if (word.Length > 0 && (char.IsLetter(word[0]) || word[0] == '_'))
//            {
//                str1 += word + " ";
//            }
//            word = "";
//        }

//    }
//    if (word.Length > 0 && (char.IsLetter(word[0]) || word[0] == '_'))
//        str1 += word + " ";
//    word = "";
//    if (str1.Length == 0) { Console.WriteLine("Identificators is absent"); return; }
//    int max = 0;
//    Console.WriteLine("Resulting list of max identificator: ");
//    for (int i = 0; i < str1.Length; i++)
//    {
//        char c = str1[i];
//        if (char.IsLetterOrDigit(c) || c == '_')
//        {
//            word += c;
//        }
//        else
//        {
//            if (max < word.Length) max = word.Length;
//            word = "";
//        }
//    }
//    if (max < word.Length) max = word.Length;
//    word = "";
//    for (int i = 0; i < str1.Length; i++)
//    {
//        char c = str1[i];
//        if (char.IsLetterOrDigit(c) || c == '_')
//        {
//            word += c;
//        }
//        else
//        {
//            if (max == word.Length)
//            {
//                Console.WriteLine($"{word}");
//            }
//            word = "";
//        }
//    }
//    if (word.Length > 0 && max == word.Length)
//        Console.WriteLine(word);
//}
