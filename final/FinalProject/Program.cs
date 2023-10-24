using System;

class Program
{
    static void Main(string[] args)
    {

        Menu menu = new Menu();
        TicketReservation program = new TicketReservation();

        int selectedMenuOption;

        Console.Clear();

        Console.WriteLine("Welcome to the Ticket Reservation Program. Written by KamCy Ahaka.");
        menu.DisplayMenu();

        Console.Write("What would you like to do? ");
        selectedMenuOption = int.Parse(Console.ReadLine());

        while (selectedMenuOption != 4)
        {
            if (selectedMenuOption == 1)
            {
                Console.WriteLine("");
                Console.Write("Please enter your first name: ");
                string userFirstName = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                string userLastName = Console.ReadLine();
                Console.Write("Please enter your age: ");
                int userAge = int.Parse(Console.ReadLine());

                User user = new User(userFirstName, userLastName, userAge);

                Console.WriteLine($"Which event would you like to book a ticket for?");

                program.ShowEvents();

                Console.Write("Enter index of event: ");

                int eventIndex = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Enter preferred seat number for this event: ");

                int seatNumber = int.Parse(Console.ReadLine());

                Event preferredEvent = program.GetEvent(eventIndex);

                Seat preferredSeat = new Seat(seatNumber, user);

                Ticket bookedTicket = new Ticket(preferredEvent, preferredSeat, user);

                user.AddNewTicket(bookedTicket);

                bookedTicket.DisplayTicketDetails();

                preferredEvent.ReserveSeat(seatNumber, preferredSeat);

                menu.DisplayMenu();

            }
            else if (selectedMenuOption == 2)
            {
                program.ShowEvents();
                menu.DisplayMenu();
            }

            else if (selectedMenuOption == 3)
            {
                Console.WriteLine("Which event would you like to remove?");
                program.ShowEvents();

                Console.Write("Enter the index of the event you would like to delete: ");
                int eventNumberToDelete = int.Parse(Console.ReadLine()
                );

                program.RemoveEvent(eventNumberToDelete - 1);


                menu.DisplayMenu();
            }


            Console.Write("What would you like to do? ");
            selectedMenuOption = int.Parse(Console.ReadLine());
        }
    }
}
