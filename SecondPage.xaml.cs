namespace MauiFlyout;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PopAsync();
    }
}