using System;

class Program
{
    static void Main()
    {
        double a = 0.1, b = 1;// диапазон изменения x
        double e = 0.0001;// заданная точность вычислений
        double k = 10, n = 10;// k — число шагов, n — фиксированное число членов ряда
        double step = (b - a) / k;// шаг изменения x
        for (int i = 0; i <= k; i++)
        {
            double x = a + i * step;// текущее значение x
            double exactAns = Math.Sin(x);// точное значение
            double sumN = 0;// сумма ряда с фиксированным n
            double termN = x;// первый член ряда
            for (int j = 0; j <= n; j++)
            {
                if (j == 0)
                    termN = x; // первый член
                else
                    termN *= -x * x / ((2 * j) * (2 * j + 1));
            }
            double sumE = 0;// сумма ряда с точностью e
            double termE = x;// первый член ряда
            int t = 0;// счётчик членов ряда
            sumE += termE;// добавляем первый член
            t++;
            termE *= -x * x / ((2 * t) * (2 * t + 1));// вычисляем второй член
            while (Math.Abs(termE) > e)// Суммируем, пока модуль превышает e
            {
                sumE += termE;// добавляем член к сумме
                t++;// увеличиваем счётчик
                termE *= -x * x / ((2 * t) * (2 * t + 1));// следующий член
            }
            Console.WriteLine($"X = {x:F2}\tSN = {sumN:F8}\tSE = {sumE:F8}\tY = {exactAns:F8}");
        }
    }
}