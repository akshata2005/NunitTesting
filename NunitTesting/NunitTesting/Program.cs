using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Unit Testing Programs.......");
            /*.........................................
             * Create a switch method to choose a particular operation 
             * ............................................*/
            Console.WriteLine("Enter an Option :");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Calculating Minimum number of notes :");
                    VendingMachine.FindingMinimumNotes();
                    break;
                case 2:
                    Console.WriteLine("Finding day of a particular date");
                    WeekDay.FindingDay();
                    break;
                case 3:
                    TempratureConversion temperaturConversion = new TempratureConversion();
                    temperaturConversion.ReadInput();
                    break;
                case 4:
                    MonthlyPayment.ReadInput();
                    break;
                case 5:
                    DecimalToBinary decimalToBinary = new DecimalToBinary();
                    decimalToBinary.ReadInput();
                    break;
                default:
                    break;
            }
        }
    }
}
