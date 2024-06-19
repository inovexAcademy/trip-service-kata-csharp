using Xunit;

namespace TripService.Test
{
    public class TripServiceTests
    {
        [Fact]
        public void GetTripsByUser_Guest_ThrowsException()
        {
            var Tom = new User();
            TripService tripService = new TripService();

            Assert.Throws<UserNotLoggedInException>(() => tripService.GetTripsByUser(Tom));
        }
    }
}
