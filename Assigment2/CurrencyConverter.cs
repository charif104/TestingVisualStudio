using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class CurrencyConverter
    {
        private double num;
        private double sum;
       

        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResult();

        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n ******The Currency Converter *****************");
            Console.WriteLine("\nWrite 0 to finish!");
            Console.WriteLine("Make sure to use correct decimal character.");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();


        }
        private void ReadInputAndSumNumbers()
        {

            bool done = false;
            while (!done)
            {
                ReadInput();
                sum += num;
                if (num == 0)
                    done = true;

            }
        }

        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            num = Input.ReadDoubleConsole();
            return num;
        }

        private void ShowResult()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.Write("This sum is: " + sum);
        }
    }
}
