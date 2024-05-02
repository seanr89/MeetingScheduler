
public record Meeting(int Id, string Title, DateTime Date, int Duration, Location Location, 
    List<Attendee> Attendees);