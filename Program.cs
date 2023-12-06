using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__ASSESSMENTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diclaring variables
            string name = "Phumelelo";
            int cellNumber = 08250250;
            string location = "Maboneng";
            // How many characters in name
            Console.WriteLine(name.Length);
            // How many characters in location
            Console.WriteLine(location.Length);

            Console.WriteLine(name + " is staying in " + location + " and her phone number is " + cellNumber );
            // check if characters "lelo" are there in name
            Console.WriteLine(name.Contains("lelo"));
            // Find characters from 2 to 4
            Console.WriteLine(location.Substring(2, 4));
            Console.ReadLine();


        }
    }
}
