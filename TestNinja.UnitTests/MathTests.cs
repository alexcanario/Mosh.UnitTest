using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgument() {
            var math = new Math();
            var result = math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
