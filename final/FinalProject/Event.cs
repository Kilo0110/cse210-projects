public abstract class Event
{
  protected string _name;
  protected DateTime _date;
  protected string _venue;
  protected int _seats;

  public Event(string name, DateTime date, string venue, int numberOfSeats)
  {
    _name = name;
    _date = date;
    _venue = venue;
    _seats = numberOfSeats;
  }

  public virtual string GetEventName()
  {
    return _name;
  }

  public abstract string GetEventDetails();
  public virtual void ReserveSeat(int seatNumber) { }
  public virtual void GetAvailableSeats() { }
}
