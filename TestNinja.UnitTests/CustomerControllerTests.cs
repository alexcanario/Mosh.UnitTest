using NUnit.Framework;

using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestFixture]
    public class CustomerControllerTests {

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound() {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            //Verifica se o resultado é do tipo NoFound
            Assert.That(result, Is.TypeOf<NotFound>());

            //Verfifica se o resultado é do tipo NotFound ou derivado de NotFound
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk() {
        }
    }
}
