using System;

namespace ExtensionClassApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassA clsa=new ClassA();
            clsa.sum(2,3);
            clsa.multiply();
            Console.WriteLine("Hello World!");
        }
    }
}
