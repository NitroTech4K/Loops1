using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops!");
            Console.WriteLine();

            int start = 0;
            int end = 4;

            int[] ammo;
            ammo = new int[5];
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 50;
            ammo[3] = 25;
            ammo[4] = 10;

            int i = start;

            //The "Count" variable is renamed to "i" so it's easier to put in the command.
            //Count = i
            //Supposed to be industry standard.

            //Instead of "int count = start", put "int i = start". 

            //The meaning of I mean an INDEX!!! Index is like the little number in the page of a book. So here we're referencing the ammo type like a page in a book". 

            


            while(i <= end)
            {
                Console.WriteLine("Weapon #" + i + "; " + ammo[i]);
                
                i = i + 1;
            }
            



            Console.ReadKey(true);
        }
    }
}
