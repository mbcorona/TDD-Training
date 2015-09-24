using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        Fibonacci fibo = new Fibonacci();
        [Test]
        public void AddTest()
        {
            Assert.That(fibo.Compute(2).Equals(" 1 2"));
            Assert.That(fibo.Compute(5).Equals(" 1 2 3 5 8"));
            Assert.That(fibo.Compute(8).Equals(" 1 2 3 5 8 13 21 34"));
        }
    }
}
