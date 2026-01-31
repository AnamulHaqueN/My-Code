using System;

class TicketService
{
    public static void BookTicket()
    {
        Console.Write("User ID: ");
        string userId = Console.ReadLine() ?? "";

        Console.Write("Schedule ID: ");
        string scheduleId = Console.ReadLine() ?? "";

        Schedule? s = DataStore.Schedules.Find(x => x.Id == scheduleId);
        if (s == null) return;

        Console.Write("Seat: ");
        int seat = int.Parse(Console.ReadLine() ?? "0");

        if (seat < 1 || seat > s.Bus.TotalSeats)
        {
            Console.WriteLine("Invalid seat!");
            return;
        }

        if (s.Bus.BookedSeats.Contains(seat))
        {
            Console.WriteLine("Seat already booked!");
            return;
        }

        s.Bus.BookedSeats.Add(seat);

        Ticket t = new Ticket
        {
            Id = IdGenerator.Generate(),
            UserId = userId,
            ScheduleId = scheduleId,
            SeatNumber = seat
        };
        DataStore.Tickets.Add(t);

        InvoiceService.CreateInvoice(t, s.TicketPrice);
        Console.WriteLine("Ticket booked!");
    }
}
