using System;

namespace AbstractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class2 cls2=new Class2();
            cls2.executeInBackGround();
            cls2.executeInForeground();
            

        }
    }
}
