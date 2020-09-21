using System;
using System.Text;

namespace CmdPrimeCalc
{
    //https://www.geeksforgeeks.org/sieve-eratosthenes-0n-time-complexity/?ref=lbp

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Low number greater than 0: ");
            var minStr = Console.ReadLine();
            int minOut;
            if (!int.TryParse(minStr, out minOut))
            {
                Console.WriteLine("Not a valid number, a default of 2 assumed.");
                minOut = 2;
            }
            if (minOut < 1)
            {
                Console.WriteLine("The number must be greater than 0, a default of 2 assumed.");
                minOut = 2;
            }

            Console.WriteLine("Enter Top number: ");
            var maxStr = Console.ReadLine();
            int maxOut;
            if (!int.TryParse(maxStr, out maxOut))
            {
                Console.WriteLine("Not a valid number! A default of 100 assumed");
                Console.ReadLine();
                maxOut = 100;
            }
            if (maxOut < minOut)
            {
                Console.WriteLine("Invalid a low number of 2 and a High number of 100 assumed.");
                Console.ReadLine();
                maxOut = 100;
            }

            //SieveOfEratosthenes method
            //create a bool array that is the length of the max number + 1 (0 based)

            bool[] primes = new bool[maxOut + 1];

            //set all the values to true
            for (int i = 0; i < maxOut; i++)
            {
                primes[i] = true;
            }

            //itterate through the numbers and test for primes, start at min supplied number 
            //if the multiple of number is smaller than the max number calculate prime
            for (int n = 2; n <= maxOut; n++)
            {
                if (primes[n] == true) //it is still marked as prime, so test if the number could actually be prime
                {
                    //however any multiples of that number will not be prime
                    //mark all multiples as not prime because it can devise by the number
                    //increment by the number
                    for (int x = n * n; x <= maxOut; x += n)
                    {
                        if (x < primes.Length && x >= 0)
                            primes[x] = false;
                    }
                }
                //else it was already marked as not prime
            }

            //now we know prime numbers by looking at the true values in the array.
            //so find the indexes where the value is still true.
            StringBuilder primeSB = new StringBuilder();
            for (int j = 0; j <= maxOut; j++)
            {
                if (primes[j] == true && minOut <= j)
                    primeSB.Append(j).Append(" : ").Append(IsPrime(j)).Append(", ");
            }

            Console.WriteLine(primeSB.ToString());
            SmallestDiv(maxOut);
        }

        public static bool IsPrime(int number)
        {
            //https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
            if (number <= 1) return false;//anything below 1 is not a prime
            if (number == 2) return true; // 2 is a default prime
            if (number % 2 == 0) return false;// anything divided by 2 is not a prime

            var boundary = (int)Math.Floor(Math.Sqrt(number));//get the prime boundary Square of the number

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        public static void SmallestDiv(int n)
        {
            
            int smallestDiv = 0;
            for (long j = n; j > 1; j--)
            {
                if (n % j == 0 && j > 0)
                {
                    smallestDiv = (int)j;
                }
            }
            Console.WriteLine(smallestDiv);
        }
    }
}
