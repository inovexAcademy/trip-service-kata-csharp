using NUnit.Framework;

namespace TripService.Test
{
    public class TripServiceTests
    {
        [Test]
        public void GetTripsByUser_Guest_ThrowsException()
        {
            var Tom = new User();
            TripService tripService = new TripService();

            Assert.Throws<UserNotLoggedInException>(() => tripService.GetTripsByUser(Tom));
        }
    }
}
