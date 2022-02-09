using System;

namespace CleanCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            static int GetValidNumber(int a, int b, int c)
            {
                if (a < b)
                    return b;
                else if (a > c)
                    return c;
                else
                    return a;
            }
        }
    }
}
