using System;

namespace TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfDisks;
            while (!int.TryParse(GetDisks(), out numOfDisks))
            {
                Console.WriteLine("This is not a number. Please enter a valid number.");
            }

            DiskMovement(numOfDisks, 'A', 'C', 'B');
            Console.WriteLine("The stack is now sorted. ");
        }

        static string GetDisks()
        {
            Console.WriteLine("How many disks would you like to move? ");
            return Console.ReadLine();
        }

        static void DiskMovement(int disks, char fromStack, char toStack, char helperStack)
        {
            if (disks <= 0)
            {
                return;
            }
            if (disks == 1)
            {
                Console.WriteLine("Move disk " + disks + " from " + fromStack + " to " + toStack);
                return;
            }
            else
            {
                DiskMovement(disks - 1, fromStack, helperStack, toStack);
                Console.WriteLine("Move disk " + disks + " from " + fromStack + " to " + toStack);
                DiskMovement(disks - 1, helperStack, toStack, fromStack);
            }
        }
    }
}
