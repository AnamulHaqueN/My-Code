class Invoice
{
    public required string Id;
    public required string TicketId;
    public required string UserId;
    public required double Amount;
    public required DateTime Date;
    public required string Status; // Paid / Unpaid
}