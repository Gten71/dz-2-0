using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение 1 переменной: ");
            string R1 = Console.ReadLine();
            Console.Write("Введите значение 2 переменной: ");
            string R2 = Console.ReadLine();
            Console.Write("Введите значение 3 переменной: ");
            string R3 = Console.ReadLine();
            double Z = (Convert.ToDouble(R1) + Convert.ToDouble(R2) + Convert.ToDouble(R3)) / 3;
            Console.Write("Среднее значение 3х переменных = " + Z.ToString());

            Console.ReadKey();
        }
    }
}
