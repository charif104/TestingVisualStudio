using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;


        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            SumNumber();
            ShowResults();

        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n ******Summation of Whole Numbers*****************");
            Console.WriteLine("           Using a for-statment\n");
            Console.WriteLine();

        }

        private void ReadInput()
        {
            Console.Write("Numbers of value to sum? ");
            numOfInput = Input.ReadIntegerConsole();
            Console.WriteLine();

        }

        private void SumNumber()
        {
            int index;
            int num = 0;
            for(index= 0; index<numOfInput; index++)
            {
                Console.Write("Please give the value no: " + (index+1)+" (Whole Number):  " );
              num += Input.ReadIntegerConsole();
            }
            sum = num;
        }

        private void ShowResults()
        {
            Console.WriteLine("--------------------\n");
            Console.WriteLine("The sum is \t{0}", sum);
        }
    }
}

