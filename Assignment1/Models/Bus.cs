using System;
using System.Collections.Generic;
class Bus
{
    public string Id;
    public string CoachNumber;
    public string BusType; // Business / Economy
    public int TotalSeats;
    public List<int> BookedSeats = new List<int>();
}