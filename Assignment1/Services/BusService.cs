using System;

class BusService
{
    public static void CreateBus()
    {
        Bus b = new Bus();
        b.Id = IdGenerator.Generate();

        Console.Write("Coach No: ");
        b.CoachNumber = Console.ReadLine() ?? "";

        Console.Write("Bus Type: ");
        b.BusType = Console.ReadLine() ?? "";
        b.TotalSeats = (b.BusType == "Business") ? 20 : 40;

        DataStore.Buses.Add(b);
        Console.WriteLine("Bus added!\n\n");
    }

    public static void ShowBuses()
    {
        foreach (var b in DataStore.Buses)
            Console.WriteLine($"Bus id: {b.Id} | Seats: {b.TotalSeats}\n\n");
    }
}