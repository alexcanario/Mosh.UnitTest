using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class ErrorLoggerTests {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty() {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error) {
            var logger = new ErrorLogger();

            //Esse teste lançara uma exceção e maneira correta
            //para testar exceções é utilizando delegates
            //logger.Log(error);

            //Maneira correta para testar exceções
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

            //Se estiver trabalhando com outros tipos de exceções
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent() {
            var logger = new ErrorLogger();

            var id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
