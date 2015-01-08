using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class VersePage : ContentPage
	{	
		public static string verse;

		public VersePage (string s)
		{
			InitializeComponent ();
			verse = s;
//			DisplayVerse();
/*			this.Content = new Label {
				Text = s,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.Center
				
			};
*/
			this.Content = new StackLayout {
				Spacing = 20, Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = s }
				}
			};
		}

		async void DisplayVerse ()
		{
			await DisplayAlert ("Verse", verse, "OK", "Cancel");
		}
	}
}

