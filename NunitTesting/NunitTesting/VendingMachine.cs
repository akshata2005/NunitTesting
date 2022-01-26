using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
    class VendingMachine
    {
        public static void FindingMinimumNotes()
        {
            Console.WriteLine("Enter a value to return Notes :");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int nCount = 0;

            int[] notesCount = new int[notes.Length];

            for (int i = 0; i < notes.Length - 1; i++)
            {
                if (amount >= notes[i])
                {
                    notesCount[i] = amount / notes[i];
                    amount -= (notesCount[i] * notes[i]);
                    nCount++;
                }

            }
            Console.WriteLine("Total Number of notes required are : " + notesCount.Length);
            Console.WriteLine("The Notes issued are :");

            for (int i = 0; i < notes.Length - 1; i++)
            {
                if (notesCount[i] != 0)
                {
                    Console.WriteLine($"{notesCount[i]} : Rs.{notes[i] }required");
                }
            }
        }
    }
}
