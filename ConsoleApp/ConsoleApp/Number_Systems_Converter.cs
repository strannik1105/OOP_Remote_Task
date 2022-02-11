using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Number_Systems_Converter
    {
        private static int[] Number_To_Array(string number)
        {
            int[] array = new int[number.Length];
            for(int i = 0; i < number.Length; i++)
            {
                if(number[i] >= '0' && number[i] <= '9')
                {
                    array[i] = number[i] - '0';
                }
                else if(number[i] >= 'A' && number[i] <= 'Z')
                {
                    array[i] = number[i] - 'A' + 10;
                }
            }
            return array;
        }

        public static void Convert(string number1, int system_base1, string number2, int system_base2)
        {

        }
    }
}
