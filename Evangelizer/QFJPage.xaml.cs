using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class QFJPage : ContentPage
	{	
		Dictionary<string, Scripture> dictionary =
			new Dictionary<string, Scripture>();

		StackLayout parent;

		public QFJPage ()
		{
			InitializeComponent ();

			dictionary.Add("Isaiah 43:6–7", 
				new Scripture("Isaiah 43:6–7", 
					"God created us for his glory", 
					"Bring my sons from afar and my daughters from the ends of the earth … whom I created for my glory\n\nIsaiah 43:6–7 (ESV)"));

			dictionary.Add("1 Corinthians 10:31", 
				new Scripture("1 Corinthians 10:31", 
					"Every human should live for God\'s glory", 
					"So, whether you eat or drink, or whatever you do, do all to the glory of God\n\n1 Corinthians 10:31 (ESV)"));

			dictionary.Add ("1 Timothy 1:15", 
				new Scripture("1 Timothy 1:15", 
					"God sent his only son Jesus to provide eternal life and joy", 
					"The saying is trustworthy and deserving of full acceptance, that Christ Jesus came into the world to save sinners\n\n1 Timothy 1:15 (ESV)"));

			dictionary.Add ("Acts 3:19; 16:31", 
				new Scripture("Acts 3:19; 16:31", 
					"The benefits purchased by the death of Christ belong to those who repent and trust him", 
					"Repent therefore, and turn again, that your sins may be blotted out\n\nActs 3:19 (ESV)\n\nBelieve in the Lord Jesus and you will be saved\n\nActs 16:31 (ESV)"));

			dictionary.Add ("What should I do?", 
				new Scripture("",
					"Turn from the deceitful promises of sin.",
					"Everyone who calls on the name of the Lord will be saved.\nRomans 10:13 (ESV)\n\nRead the Bible.\n\nPray.\n\nAttend a Bible-believing church."));

			parent = new StackLayout ();

			// Add heading
			Label heading = new Label { Text = "Quest for Joy", 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Bold };
			parent.Children.Add (heading);

			// Add buttons
			Button add = new Button { Text = dictionary["Isaiah 43:6–7"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["1 Corinthians 10:31"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["1 Timothy 1:15"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["Acts 3:19; 16:31"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = "What should I do?" };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			Content = parent;

		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			// Navigate to a new page to display the verse
			await this.Navigation.PushAsync(new TestVersePage(dictionary[button.Text]));
		}
	}
}

