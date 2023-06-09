using System.Diagnostics;

namespace CarouselViewNotDetectingSwipe;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}

	private void OnSwipe(object sender, SwipedEventArgs e)
	{
		Debug.WriteLine("Something should happen here.");
	}
	
}

