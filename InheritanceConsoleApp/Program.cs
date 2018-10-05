using System;

namespace InheritanceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassB bcla=new ClassB();
            Console.WriteLine(bcla.sum(2,3));
            Console.WriteLine(bcla.multiply(2,3));
        }
    }
}
