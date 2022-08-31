using Xamarin.Google.Crypto.Tink.Signature;

namespace MauiLogbook.Models;

public class Trip
{
    public int Id { get; set; }

    public double Value { get; set; }

    public string SourceLocation { get; set; }

    public string DestinationLocation { get; set; }

    public Vehicle Vehicle { get; set; }
}


public class TripSummary
{
    public int Id { get; set; }

    public string Text { get; set; }

    public double Value { get; set; }   

    public List<Trip> Trips { get; set; }
}

public class Vehicle
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Icon { get; set; }
}
