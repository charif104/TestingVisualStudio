using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    public class Input
    {
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            return input;
            else
            Console.Write("Wrong input , please enter an integer: ");
            return ReadIntegerConsole();
        }

        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else 
                Console.Write("Wrong input , please enter an integer: ");
            return ReadDoubleConsole();
        }
    }
}
