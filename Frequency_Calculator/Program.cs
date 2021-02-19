using System;
using System.Collections.Generic;
using System.Linq;

namespace Frequency_Calculator
{
    class Parameters
    {
        
    }

    class Program
    {        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a base frequency");
            double baseFrequency = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of harmonics to be calculated");
            int numOfHarmonics = int.Parse(Console.ReadLine());

            int[] multipliers = Enumerable.Range(1, numOfHarmonics).ToArray();
            double[] calculatedHarmonics = new double[numOfHarmonics];
            for (int i = 0; i < numOfHarmonics; i++)
            {
                calculatedHarmonics[i] = baseFrequency * multipliers[i];
                Console.WriteLine("Harmonic #" + multipliers[i] + ": " + calculatedHarmonics[i]);
                
            }

            

        }
    }
}
