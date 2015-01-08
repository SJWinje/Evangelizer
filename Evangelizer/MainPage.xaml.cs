using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class MainPage : ContentPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			switch (button.Text) {
			case "Romans Road":
				await this.Navigation.PushAsync(new RomansRoadPage());
				break;
			
			case "Quest for Joy":
				await this.Navigation.PushAsync(new QFJPage());
				break;

			}
		}

	}

}

