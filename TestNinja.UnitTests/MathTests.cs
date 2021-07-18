using System.Runtime.CompilerServices;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class MathTests {
        private Math _math;

        //setup
        //teardown
        
        [SetUp]
        private void SetUp() {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgument() {
            var result = _math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() {
            var result = _math.Max(3, 1);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() {
            var result = _math.Max(1, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {
            var result = _math.Max(3, 3);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
