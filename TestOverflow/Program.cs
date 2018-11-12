using System;

namespace TestOverflow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte b1 = 255;
            b1++; //Overflow: b1 = 0
            b1++; //b1 = 1

            //Prints the value 1. No exception is thrown.
            Console.WriteLine(b1);

            byte b2 = 255;

            //checked is used to throw an OverflowException if overflow occurs.
            checked
            {
                b2++; //Overflow, OverflowException is thrown.
                Console.WriteLine(b2);
            }
        }
    }
}
