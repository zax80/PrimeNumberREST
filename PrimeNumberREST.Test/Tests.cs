using NUnit.Framework;
using PrimeNumberREST.Services;

namespace PrimeNumberREST.Test
{
    public class Tests
    {
        public PrimeNumberService service;

        [SetUp]
        public void Setup()
        {
            service = new PrimeNumberService();
        }

        [Test]
        public void IsPrimeNumberTest()
        {
           
            Assert.IsFalse(service.IsPrime(1));
            Assert.IsTrue(service.IsPrime(5));
            Assert.AreEqual(199, service.FindNextPrime(197));
        }

        [Test]
        public void FindNextPrimeTest()
        {
            Assert.AreEqual(199, service.FindNextPrime(197));
        }
    }
}