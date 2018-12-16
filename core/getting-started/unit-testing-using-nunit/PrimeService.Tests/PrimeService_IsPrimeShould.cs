using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [Test]
        public void ReturnTrueGivenValueOf5()
        {
            var result = _primeService.IsPrime(5);

            Assert.IsTrue(result, "5 should be prime");
        }
        public void ReturnTrueGivenValueOf98()
        {
            var result = _primeService.IsPrime(98);

            Assert.IsTrue(result, "98 should be prime");
        }


        #region Sample_TestCode
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
        #endregion
    }
}
