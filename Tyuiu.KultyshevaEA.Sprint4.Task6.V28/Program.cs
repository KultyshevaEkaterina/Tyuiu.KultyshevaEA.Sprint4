using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KultyshevaEA.Sprint4.Task6.V28.Lib;

namespace Tyuiu.KultyshevaEA.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Култышева Е. А. | ИИПБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПБ-23-3                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [Река, Озеро, Болото, Океан, Лужа, Море],  используя                    *");
            Console.WriteLine("* класс Array, выведите элементы массива, длина которых равна 4 символам. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i<= data.Length-1; i++)
            {
                Console.WriteLine(data[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(data);

            Console.WriteLine("Элементы массива, длина которых равна 4 символам: "  );
            for (int i = 0; i <= res.Length-1; i++)
            {
                Console.Write($"{res[i]}\n");
            }
                Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}
