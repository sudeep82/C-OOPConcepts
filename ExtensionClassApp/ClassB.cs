using System;
namespace ExtensionClassApp{
    public static class ClassB
    {
        public static void multiply(this ClassA cls)
        {
            cls.x=4;
            cls.y=5;
            Console.WriteLine(cls.x*cls.y);

        }

    }
}