using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KultyshevaEA.Sprint4.Task3.V25.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5,5] { {7,3,5,3,6 },
                                         {4,6,2,5,7 },
                                         {2,3,3,3,5 },
                                         {2,7,7,6,2},
                                         {6,6,4,3,6 }   };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length/rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Култышева Е. А. | ИИПБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПБ-23-3                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 7 подсчитать                *");
            Console.WriteLine("* произведение элементов 4 столбца массива.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i<rows; i++)
            {
                for (int j = 0; j<columns;j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Произведение элементов 4 столбца = " + res);

            Console.ReadKey();
        
        }
    }
}
