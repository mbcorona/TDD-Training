using NUnit.Framework;
namespace CSharp.Training.Tests
{
    [TestFixture]
    public class PalindromeTest
    {
        Palindrome pl = new Palindrome();
        [Test]
        public void AddTest()
        {
            Assert.That(pl.Compute("anitalavalatina"));
            Assert.That(pl.Compute("oso"));
            Assert.That(!pl.Compute("estonoespalindromo"));
            Assert.That(!pl.Compute("estotampoco"));
            Assert.That(pl.Compute("aabbccbbaa"));
        }
    }
}