namespace MauiLogbook.Pages;

public partial class NewTrackPage : ContentPage
{
	public NewTrackPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        App.Current.MainPage.Navigation.PopModalAsync();
    }
}