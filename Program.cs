using static System.Console;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            checked
            {
                for (byte i = 0; i < max; i++)
                {
                        WriteLine(i);
                }
            }
        }
    }
}
