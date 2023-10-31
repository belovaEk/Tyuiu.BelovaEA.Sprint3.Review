using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint3.TaskReview.V8.Lib;

namespace Tyuiu.BelovaEA.Sprint3.TaskReview.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: SprintReview                                                      *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                 cos(x)+1                                                *");
            Console.WriteLine("* f(x) = sin(x) + --------- + 2x    на диапазоне от [-5; 5]               *");
            Console.WriteLine("*                   2-x                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Начало отрезка = {start}\nКонец отрезка = {stop}");
            Console.WriteLine("***************************************************************************");

            int len = ds.GetMassFunction(start, stop).Length;

            double[] array;
            array = new double[len];

            array = ds.GetMassFunction(start, stop);
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}  |", start, array[i]);
                start++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
