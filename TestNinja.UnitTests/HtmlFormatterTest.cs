using NUnit.Framework;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class HtmlFormatterTest {
        [Test]
        [TestCase("abc")]
        public void FormatAsBold_WhenCalled_SholdEncloseTheStringWithStrongElement(string text) {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold(text);
            
            //Specific test
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);
            
            //More general
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.Contain(text).IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
        }
    }
}
