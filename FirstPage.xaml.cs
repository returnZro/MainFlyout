namespace MauiFlyout;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
	    InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
	    this.Loaded += (s, e) =>
            {
                this.Handler?.UpdateValue(nameof(IView.Opacity));
            };
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
	Application.Current.MainPage.Navigation.PushAsync(new SecondPage());
    }

        protected override void LayoutChildren(double x, double y, double width, double height)
    {
        Console.WriteLine($"##### - Detail LayoutChildren before base: {DateTime.Now}");
        base.LayoutChildren(x, y, width, height);
        Console.WriteLine($"##### - Detail LayoutChildren after base:{DateTime.Now}");
    }
}
