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

        private static int To_Decimal(string number, int system_base)
        {
            int decimal_number = 0;
            for(int i = 0; i < Number_To_Array(number).Length; i++)
            {
                decimal_number += Number_To_Array(number)[i] * (int)Math.Pow(system_base, (Number_To_Array(number).Length - i - 1));
            }
            return decimal_number;
        }

        private static string To_N_system(int decimal_number, int system_base)
        {
            string number = "";
            while(decimal_number > 0)
            {
                if(decimal_number%system_base < 10)
                {
                    number += (decimal_number % system_base).ToString();
                }
                else if(decimal_number%system_base > 10 && decimal_number % system_base < 'Z' - 'A' + 10)
                {
                    number += (char)((decimal_number % system_base) + 'A' - 10);
                }
                decimal_number /= system_base;
                
            }
            return new string(number.ToCharArray().Reverse().ToArray());
        }

        public static string Convert(string number, int system_base1, int system_base2)
        {
            return To_N_system(To_Decimal(number, system_base1), system_base2);
        }
    }
}
