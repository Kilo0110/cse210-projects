public class Seat
{
  private int _seatNumber;

  public void SetSeat(int number)
  {
    _seatNumber = number;
  }

  public string GetSeat()
  {
    return $"Seat number: {_seatNumber}";
  }
}
