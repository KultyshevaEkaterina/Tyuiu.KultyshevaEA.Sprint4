using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KultyshevaEA.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0); 
            int columns = array.GetLength(1); 

            int count = 1;

            
            for (int i = 0; i < rows; i++)
            {
                count *= array[i, 3]; 
            }

            return count; 
        }
    }
}
