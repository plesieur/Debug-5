using System;
using System.Reflection.Metadata.Ecma335;

namespace Debug_5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //This will calculate the power of 2 using a brute force loop method
            Console.WriteLine("2 to the 10th={0}", power2Loop(10));

            //This will calulate the power of 2 using brute force recurion method
            Console.WriteLine("2 to the 10th={0}", power2(10));

            //This trivial program will add 2 and then subtract 1 using two methods.
            Console.WriteLine("Two Steps Forward, One Step Back = {0}", Stepping(0));
        }

        static int Stepping(int steps)
        {
            int rv = steps;
            steps = Forward2(steps);
            steps = Backwards1(steps);

            return steps;
        }

        //Add 2 before subtracting 1
        static int Forward2(int adder)
        {
            adder += 2;
            return adder;
        }

        //Subtract 1
        static int Backwards1(int subtractor)
        {
            subtractor--;
            return Stepping(subtractor);  //Return value to Stepping
        }

        //calculate the power of 2 using recursion
        static int power2(int power)
        {
            return power2(power - 1) * 2;
        }

        //calculate the power of 2 using a loop
        static int power2Loop(int power)
        {
            int rv = 0;
            int i = 0;

            while (i < power )
                rv = rv * 2;
                i++;

            return rv;
        }

    }
}
