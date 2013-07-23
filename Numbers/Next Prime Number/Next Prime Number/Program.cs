using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            Console.Write("Next prime number? ");
            while (Console.ReadKey().Key.ToString().ToUpper().Equals("Y"))
            {
                prime = findNextPrime(prime);
                Console.WriteLine("\nprime: " + prime);
                Console.Write("Next prime number? ");
            }
        }

        // http://www.wikihow.com/Check-if-a-Number-Is-Prime
        static int findNextPrime(int currentPrime)
        {
            currentPrime++;
            bool foundNextPrime = false;
            while (!foundNextPrime)
            {
                if (currentPrime % 2 == 0)
                {
                    //no prime number
                    currentPrime++;
                    continue;
                }
                if (currentPrime % 3 == 0 && currentPrime > 3)
                {
                    //no prime number
                    currentPrime++;
                    continue;
                }
                bool subFound = true;
                for (int i = 2; i <= Math.Pow(currentPrime, 0.5);i++ )
                {
                    if (currentPrime % i == 0)
                    {
                        //no prime number
                        currentPrime++;
                        subFound = false;
                        break;
                    }
                    else
                    {

                    }
                }
                if (subFound == false)
                    continue;
                foundNextPrime = true;
            }
            return currentPrime;
        }
    }
}
