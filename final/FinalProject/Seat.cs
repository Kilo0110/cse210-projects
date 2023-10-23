public class Seat
{
  private int _seatNumber;
  private User _user;

  public Seat(int number, User user)
  {
    _seatNumber = number;
    _user = user;
  }

  public string GetSeatDetails()
  {
    return $"Seat number: {_seatNumber}";
  }
}
