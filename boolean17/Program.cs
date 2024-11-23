using System;
using static System.Console;

namespace boolean17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            bool result = a>99 && a<1000 && a%2!=0;
            WriteLine(result);
        }
    }
}