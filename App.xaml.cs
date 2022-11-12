namespace MapDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MapsPage();
	}
}

public	class MapsPage : ContentPage
{
	public MapsPage()
	{
		Content = new Microsoft.Maui.Controls.Maps.Map();
	}
}
