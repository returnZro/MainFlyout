namespace MauiFlyout;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage.Navigation.PushAsync(new SecondPage());
    }
}