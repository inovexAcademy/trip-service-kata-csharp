namespace TripService
{
    public class UserNotLoggedInException : System.Exception
    {

    }

    public class CollaboratorCallException : System.Exception
    {
        public CollaboratorCallException(string message) : base(message) { }
    }
}