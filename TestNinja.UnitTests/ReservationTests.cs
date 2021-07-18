using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests {
    [TestClass]
    public class ReservationTests {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() {
            //CanBeCancelledBy_Scenario_ExpectedBehavior
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CaBeCancelledBy_SameUserCancellingTheReservation_ReturnsFalse() {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            Assert.IsFalse(result);
        }
    }
}
