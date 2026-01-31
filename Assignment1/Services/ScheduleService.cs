using System;

class ScheduleService
{
    public static void CreateSchedule()
    {
        Console.Write("Bus ID: ");
        string busId = Console.ReadLine() ?? "";

        Bus? bus = DataStore.Buses.Find(b => b.Id == busId);
        if (bus == null) return;

        Schedule s = new Schedule();
        s.Id = IdGenerator.Generate();
        s.Bus = bus;

        Console.Write("From: ");
        s.From = Console.ReadLine() ?? "";
        Console.Write("To: ");
        s.To = Console.ReadLine() ?? "";

        Console.Write("Price: ");
        s.TicketPrice = double.Parse(Console.ReadLine() ?? "0");

        DataStore.Schedules.Add(s);
        Console.WriteLine("Schedule added!\n\n");
    }

    public static void ShowSchedules()
    {
        foreach (var s in DataStore.Schedules)
            Console.WriteLine($"Schedule id: {s.Id} | {s.From} -> {s.To}\n\n");
    }
}
