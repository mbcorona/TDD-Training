using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class PerfectNumberTest
    {
        PerfectNumber pn = new PerfectNumber();

        [Test]
        public void AddTest()
        {
            Assert.That(pn.Compute(6));
            Assert.That(pn.Compute(28));
            Assert.That(pn.Compute(496));
            Assert.That(!pn.Compute(20));
            Assert.That(!pn.Compute(30));
        }
    }
}
