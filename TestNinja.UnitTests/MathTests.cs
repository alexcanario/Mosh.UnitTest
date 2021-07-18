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

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() {
            var math = new Math();
            var result = math.Max(3, 1);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() {
            var math = new Math();
            var result = math.Max(1, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {
            var math = new Math();
            var result = math.Max(3, 3);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
