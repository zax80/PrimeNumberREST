using System;

namespace PrimeNumberREST.Services
{
    public class PrimeNumberService : IPrimeNumberService
    {

        // Function to return the smallest  
        // prime number greater than 'number'
        public int FindNextPrime(int number)
        {

            // Base case  
            if (number <= 1)
                return 2;

            int prime = number;
            bool found = false;

            // Loop continuously until isPrime  
            // returns true for a number  
            // greater than n  
            while (!found)
            {
                prime++;

                if (IsPrime(prime))
                    found = true;
            }
            return prime;
        } 

        // Function that returns true if 'number'  
        // is prime else returns false
        public bool IsPrime(int number)
        {
            // Corner cases  
            if (number <= 1) return false;
            if (number <= 3) return true;

            // This is checked so that we can skip  
            // middle five numbers in below loop  
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
                if (number % i == 0 ||
                    number % (i + 2) == 0)
                    return false;

            return true;
        }
    }
}