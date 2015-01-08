using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class RomansRoadPage : ContentPage
	{	
		Dictionary<string, string> dictionary =
			new Dictionary<string, string>();


		public RomansRoadPage ()
		{
			InitializeComponent ();

			dictionary.Add("Romans 3:23", "All have sinned and fall short of the glory of God\n\nRomans 3:23 (ESV)");
			dictionary.Add("Romans 6:23a", "For the wages of sin is death\n\nRomans 6:23a (ESV)");
			dictionary.Add("Romans 5:8", "But God shows his love for us in that while we were still sinners, Christ died for us\n\nRomans 5:8 (ESV)");
			dictionary.Add("Romans 10:9", "If you confess with your mouth that Jesus is Lord and believe in your heart that God raised him from the dead, you will be saved\n\nRomans 10:9 (ESV)");
			dictionary.Add("Romans 6:23b", "But the free gift of God is eternal life in Christ Jesus our Lord\n\nRomans 6:23b (ESV)");
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			// Navigate to a new page to display the verse
			await this.Navigation.PushAsync(new VersePage(dictionary[button.Text]));
		}
	}
}

