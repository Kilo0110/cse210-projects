public class TheaterPlay : Event
{
  private string _playWright;

  public TheaterPlay(string name, DateTime date, string venue, int numberOfSeats, string playWright) : base(name, date, venue, numberOfSeats)
  {
    _playWright = playWright;
  }

  public override string GetEventDetails()
  {
    return $"Event Name: {_name}\nDate: {_date}\nVenue: {_venue}\nNumber of Seats: {_seats}\nPlayWright: {_playWright}";
  }

  public override void ReserveSeat(int seatNumber)
  {

  }

  public override string GetAvailableSeats()
  {
    return "";
  }
}
