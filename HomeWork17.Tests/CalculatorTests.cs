using NUnit.Framework.Constraints;

namespace HomeWork17.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        static Account GetAccount(double bal, int typeAcc)
        {
            switch (typeAcc)
            {
                case 0:
                    return new SalatyAccount(bal);
                case 1:
                    return new OrdinaryAccount(bal);
                default:
                    throw new NotImplementedException();
            }
        }

        [Test]
        [TestCase(100, 0, 50)]
        [TestCase(1000, 1, 0)]
        [TestCase(500, 1, 100)]
        public void SetInterestMustCorrectReturnValue(double bal, int typeAcc, double expected)
        {
            var acc = GetAccount(bal, typeAcc);
            var calc = new Calculator();

            calc.SetInterest(acc);
            var actual = acc.Interest;
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}