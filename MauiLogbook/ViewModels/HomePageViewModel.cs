using MauiLogbook.Models;

namespace MauiLogbook.ViewModels;

public class HomePageViewModel
{
    public List<TripSummary> Summary { get; set; } = new List<TripSummary>
    {
        new()
        {
            Text = "This Week",
            Id = 1,
            Value = 130
        },
        new()
        {
            Text = "This Month",
            Id = 2,
            Value = 450
        },
        new()
        {
            Text = "This Year",
            Id = 1,
            Value = 3457
        }
    };
}



