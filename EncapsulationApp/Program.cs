using System;

namespace EncapsulationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int val1,val2;
            EncapsulationAppClass enc =new EncapsulationAppClass();
            Console.WriteLine("First Input");
            enc.val1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("second Input");
           enc.val2= Convert.ToInt32(Console.ReadLine());

            
            
            enc.display();

        }
    }
}
