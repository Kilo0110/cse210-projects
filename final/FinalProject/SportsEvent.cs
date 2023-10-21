public class SportsEvent : Event
{
  private string _sportsType;
  private string _teamOne;
  private string _teamTwo;

  public SportsEvent(string name, DateTime date, string venue, int numberOfSeats, string teamOne, string teamTwo, string sportsType) : base(name, date, venue, numberOfSeats)
  {
    _sportsType = sportsType;
    _teamOne = teamOne;
    _teamTwo = teamTwo;
  }

  public override string GetEventDetails()
  {
    return $"Event Name: {_name}\nDate: {_date}\nVenue: {_venue}\nNumber of Seats: {_seats}\nSport Name: {_sportsType}\n{_teamOne} v {_teamTwo}";
  }

  public override void ReserveSeat(int seatNumber)
  {

  }

  public override string GetAvailableSeats()
  {
    return "";
  }
}
