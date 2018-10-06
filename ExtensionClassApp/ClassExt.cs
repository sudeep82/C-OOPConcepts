using System;
namespace ExtensionClassApp{
public static class ClassExt
{
    public static void multiply(this ClassOrig cls)
    {
        cls.x=5;
        cls.y=6;
        Console.WriteLine(cls.x*cls.y);
    }

}
}