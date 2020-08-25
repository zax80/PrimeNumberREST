namespace PrimeNumberREST.Services
{
    public interface IPrimeNumberService
    {
        bool IsPrime(int number);

        int FindNextPrime(int number);
    }
}