using System;
namespace EncapsulationApp
{
    public class EncapsulationAppClass
    {
        private int value1;
        private int value2;

        public int val1{
            get
            {
                return value1;
            }
            set{
                value1=value;
            }
           
        }

        public int val2{
            get
            {
                return value2;
            }
            set{
                value2=value;
            }
           
        }


        private int multiply(){
            return value1*value2;
        }

        public void display()
        {
           Console.WriteLine("Result of the output is "+multiply());
        }
    }
}