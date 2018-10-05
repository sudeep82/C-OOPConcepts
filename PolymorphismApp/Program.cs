using System;
using System.Collections.Generic;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var li=new List<RyanHomeBuilder>{
                        new MilanModel(),
                        new Torino(),
                        new RomeModel()
            };

            //polymorphism perfect example
            foreach(var xy in li){
                xy.BuildHomes();
            }

            MilanModel m=new MilanModel();
            Console.WriteLine(m.ToString());



            Console.WriteLine("Hello World!");
        }
    }
}
