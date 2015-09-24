using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz fb = new FizzBuzz();
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void AddTestThree(int n)
        {
            Assert.That(fb.Compute(n).Equals("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void AddTestFive(int n)
        {
            Assert.That(fb.Compute(n).Equals("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        public void AddTestThreeAndFive(int n)
        {
            Assert.That(fb.Compute(n).Equals("FizzBuzz"));
        }

    }
}
