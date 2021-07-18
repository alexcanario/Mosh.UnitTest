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
        public void SetUp() {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArgument() {
            var result = _math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        [TestCase(1,3,3)]
        [TestCase(3,1,3)]
        [TestCase(3,3,3)]
        public void Max_WheCalled_ReturnTheGreater(int a, int b, int resultExpected) {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(resultExpected));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() {
            var result = _math.Max(1, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {
            var result = _math.Max(3, 3);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
