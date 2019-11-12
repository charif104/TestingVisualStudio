using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment2
{
    class Menu
    {
        int choice;
        public void Start()
        {
             choice = -1;
            while (choice != 0)
            {
                WriteMenuText();
                choice = Input.ReadIntegerConsole();
                switch (choice)
                {
                    case 1:
                        WholeNumbersForAdd sumobj = new WholeNumbersForAdd();
                      sumobj.Start();
                        break;

                    case 2:
                        FloatingPointsNumberWhileAdd flow = new FloatingPointsNumberWhileAdd();
                        flow.Start();
                        break;
                             

                }
            }
        }

        public void WriteMenuText()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("                   Main Menu                               ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("  Whole Numbers with for               :  1                ");
            Console.WriteLine("  Floating Poing Numbers with While    :  2                 ");
            Console.WriteLine("  Currency Converter With Do While Loop:  3                 ");
            Console.WriteLine("  Work Schedule                        :  4                 ");
            Console.WriteLine("  Exit the Program                     :  0                 ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("  Your Choise:   ");
        }

    }
}
