using MauiLogbook.ViewModels;

namespace MauiLogbook.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new HomePageViewModel();
	}
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        App.Current.MainPage.Navigation.PushModalAsync(new NewTrackPage());
    }

}