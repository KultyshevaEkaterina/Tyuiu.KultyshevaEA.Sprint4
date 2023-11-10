using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KultyshevaEA.Sprint4.Task4.V6.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task4.V6
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
                Console.WriteLine("* Задание #4                                                              *");
                Console.WriteLine("* Вариант #6                                                              *");
                Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПБ-23-3                *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
                Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Заменить                 *");
                Console.WriteLine("* нечетные элементы массива на 0.                                         *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                Console.Write("Введите количество строк в массиве: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество столбцов в массиве: ");
                int columns = Convert.ToInt32(Console.ReadLine());

                int[,] mtrx = new int[rows, columns];

                Console.WriteLine("***************************************************************************");
                
                for (int i = 0; i<rows;i++)
                { 
                    for (int j = 0; j<columns; j++)
                    {
                        Console.Write($"Введите {i},{j}  элемент массива: ");
                        mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nМассив:");
                for (int i = 0; i<rows;i++)
                {
                    for (int j =0; j<columns; j++)
                    {
                        Console.Write($"{mtrx[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                int [,] res = ds.Calculate(mtrx);

                Console.WriteLine("Получившаяся матрица: " );
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        Console.Write($"{res[i, j]} \t");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
                }
    }
}
