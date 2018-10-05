using System;
namespace AbstractionApp{
    public abstract class Class1{
        public abstract void executeInBackGround();

        public void executeInForeground(){
            Console.WriteLine("executing in foreground");
        }

        
    }
}