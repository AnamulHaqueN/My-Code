class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Create User 2.Show Users 3.Create Bus 4.Show Buses");
            Console.WriteLine("5.Create Schedule 6.Show Schedules 7.Book Ticket");
            Console.WriteLine("8.Show Invoices 9.Pay Invoice 10.Show Tickets 0.Exit");

            int choice = int.Parse(Console.ReadLine()??"0");

            if (choice == 1) UserService.CreateUser();
            else if (choice == 2) UserService.ShowUsers();
            else if (choice == 3) BusService.CreateBus();
            else if (choice == 4) BusService.ShowBuses();
            else if (choice == 5) ScheduleService.CreateSchedule();
            else if (choice == 6) ScheduleService.ShowSchedules();
            else if (choice == 7) TicketService.BookTicket();
            else if (choice == 9) InvoiceService.PayInvoice();
            else if (choice == 0) break;
        }
    }
}
