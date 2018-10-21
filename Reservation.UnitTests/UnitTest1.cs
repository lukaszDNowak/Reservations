using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 

namespace Reservation.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new ();
            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            // Assert
            Assert.IsTrue(result);
        }
    }
}
