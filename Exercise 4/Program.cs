using System;
using static System.Console;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Podaj liczbę od 0 do 255: ");
                byte first = byte.Parse(Console.ReadLine());
                Write("Podaj inną liczbę od 0 do 255: ");
                byte second = byte.Parse(Console.ReadLine());
                Write($"{first} podzielone przez {second} to {first / second}");
                ReadKey();
            }
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} - {ex.Message}");
            }
        }
    }
}
