using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод числа: ");
            Console.Write("\tЧисло: ");
            string number = Console.ReadLine();
            Console.Write("\tСистема счисления: ");
            int system_base = Int32.Parse(Console.ReadLine());
            Console.Write("Новая система счисления: ");
            int new_system_base = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {Number_Systems_Converter.Convert(number, system_base, new_system_base)}");
        }
    }
}
