public class Ticket
{
  private Event _event;
  private Seat _seat;
  private User _user;

  public Ticket(Event @event, Seat seat, User user)
  {
    _event = @event;
    _seat = seat;
    _user = user;
  }
}
