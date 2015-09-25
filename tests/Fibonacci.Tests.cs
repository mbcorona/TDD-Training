using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        Fibonacci fibo = new Fibonacci();
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(7, 13)]
        [TestCase(17, 1597)]
        [TestCase(43, 433494437)]
        [Timeout(10000)]
        public void AddTest(int input, int output)
        {
            Assert.That(fibo.Compute(input).Equals(output));
        }
    }
}
