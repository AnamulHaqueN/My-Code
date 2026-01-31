using System;

class InvoiceService
{
    public static void CreateInvoice(Ticket t, double amount)
    {
        Invoice i = new Invoice
        {
            Id = IdGenerator.Generate(),
            TicketId = t.Id,
            UserId = t.UserId,
            Amount = amount,
            Date = DateTime.Now,
            Status = "Unpaid"
        };

        DataStore.Invoices.Add(i);
    }

    public static void PayInvoice()
    {
        Console.Write("Invoice ID: ");
        string id = Console.ReadLine() ?? "";

        Invoice? i = DataStore.Invoices.Find(x => x.Id == id);
        if (i != null && i.Status == "Unpaid")
        {
            i.Status = "Paid";
            Console.WriteLine("Payment successful!");
        }
    }
}
