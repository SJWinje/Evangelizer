using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
//			InitializeComponent ();
			this.Content = new TableView {
				Intent = TableIntent.Settings,
				Root = new TableRoot {
					new TableSection (" ") {
						new SwitchCell {Text = "Airplane Mode"},
						new SwitchCell {Text = "Notifications"}
					},
					new TableSection (" ") {
						new EntryCell { Label="Login", Placeholder = "username" }
						, new EntryCell {Label="Password", Placeholder = "password" }
					},
					new TableSection ("Silent") {
						new SwitchCell {Text = "Vibrate", },
						new ViewCell { View = new Slider() }
					},

					new TableSection ("Ring") {
						new SwitchCell {Text = "New Voice Mail"},
						new SwitchCell {Text = "New Mail", On = true}
					},
				},
			};
		}
	}

}

