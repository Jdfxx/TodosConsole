namespace Playground;

public class HotelBooking
{
    public readonly string GuestName;
    DateTime StartDate;
    DateTime EndDate;

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = StartDate.AddDays(lengthOfStayInDays);
    }
}