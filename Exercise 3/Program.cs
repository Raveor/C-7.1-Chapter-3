using static System.Console;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i != 1)
                {
                    Write(", ");
                }
                bool flag = false;
                if (i % 3 == 0)
                {
                    Write("Fizz");
                    flag = true;
                }
                if (i % 5 == 0)
                {
                    Write("Buzz");
                    flag = true;
                }
                if(!flag)
                {
                    Write(i);
                }
            }
            ReadKey();
        }
    }
}
