using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's Start Programming 

            //variables

            int x; //Declaration

            x = 12; //Initialization

            int y = 21; // Declaration + Initialisation;

            int z = x + y; // summation 

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("The Sum of X & Y is "+z);

            int age = 23;
            Console.WriteLine("Your Age is = "  +   age );
            double height = 1233.69;
            Console.WriteLine("Your Height is = " + height + "cm");
            bool alive = true;
            Console.WriteLine("Are you alive? " + alive);
            char symbol = '$';
            Console.WriteLine(symbol);
            String name = "bro"; 
            Console.WriteLine(name+symbol);


            Console.ReadLine();

        }
    }
}
