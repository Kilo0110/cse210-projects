public class TicketReservation
{
  private List<Event> _events = new List<Event>();
  // private User _user;

  public TicketReservation()
  {
    Concert musicConcert = new Concert("BYU Music Festival", new DateTime(), "Idaho", 10000, "Strive to be");

    SportsEvent footballMatch = new SportsEvent("El Classico", new DateTime(), "Spotify Camp Nou", 90000, "Barcelona", "Madrid", "Football");

    TheaterPlay hamletPlay = new TheaterPlay("Hamlet", new DateTime(), "BYUI Arts Center", 500, "William Shakespaere");

    _events.Add(musicConcert);
    _events.Add(footballMatch);
    _events.Add(hamletPlay);
  }

  public void ShowEvents()
  {
    _events.ForEach(eventItem =>
    {
      Console.WriteLine($"{_events.IndexOf(eventItem) + 1}. {eventItem.GetEventDetails()}\n");
    });
  }

}
