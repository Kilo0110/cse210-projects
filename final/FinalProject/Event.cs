public abstract class Event
{
  protected string _name;
  protected DateTime _date;
  protected string _venue;
  protected Seat[] _seats;
  protected bool[] _seatsAreFilled;



  public Event(string name, DateTime date, string venue, int numberOfSeats)
  {
    _name = name;
    _date = date;
    _venue = venue;
    _seats = new Seat[numberOfSeats];
    _seatsAreFilled = new bool[numberOfSeats];
  }

  public virtual string GetEventName()
  {
    return _name;
  }

  public abstract string GetEventDetails();

  public virtual void ReserveSeat(int seatNumber, Seat seat)
  {
    _seats[seatNumber] = seat;
    _seatsAreFilled[seatNumber] = true;
  }

  public virtual int GetAvailableSeats()
  {
    int availableSeats = 0;

    foreach (bool value in _seatsAreFilled)
    {
      if (value == false)
      {
        availableSeats++;
      }
    }

    return availableSeats;
  }
}
