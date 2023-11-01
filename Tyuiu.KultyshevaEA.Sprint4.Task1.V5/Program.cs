using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KultyshevaEA.Sprint4.Task1.V5.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Култышева Е. А. | ИИПБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПБ-23-3                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму          *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[15];
            Console.Write("Введите элементы массива: ");

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numsArray[i] = number;
                }
                Console.WriteLine("Массив:  " + numsArray + "\t");
            }



                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(numsArray));

                Console.ReadKey();
            }
        }
}
