using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Rezerwacja;

namespace Rezerwacja.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert
            Assert.IsTrue(result);
        }

        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
       
        public void check()
        {
            var calculate = new Testy();
            var result = calculate.calculate(-1);
            Assert.AreEqual("FizzBuzz", result);
        }

       
    }
}

