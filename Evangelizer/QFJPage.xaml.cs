using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class QFJPage : ContentPage
	{	
		Dictionary<string, Scripture> dictionary =
			new Dictionary<string, Scripture>();

		string [] dKey = new string[] {
			"Isaiah 43:6–7", 
			"1 Corinthians 10:31", 
			"Romans 3:23",
			"Romans 6:23", 
			"1 Timothy 1:15", 
			"Acts 3:19; 16:31", 
			"What should you do?"};

		StackLayout parent;

		public QFJPage ()
		{
			int i = 0;

			InitializeComponent ();

			dictionary.Add(dKey[i++], 
				new Scripture("Isaiah 43:6–7", 
					"1) God created us for his glory", 
					"Bring my sons from afar and my daughters from the ends of the earth … whom I created for my glory\n\nIsaiah 43:6–7 (ESV)"));

			dictionary.Add(dKey[i++], 
				new Scripture("1 Corinthians 10:31", 
					"2) Every human should live for God\'s glory", 
					"So, whether you eat or drink, or whatever you do, do all to the glory of God\n\n1 Corinthians 10:31 (ESV)"));

			dictionary.Add(dKey[i++], 
				new Scripture("Romans 3:23", 
					"3) All of us have failed to glorify God as we should", 
					"All have sinned and fall short of the glory of God\n\nRomans 3:23 (ESV)"));

			dictionary.Add(dKey[i++], 
				new Scripture("Romans 6:23", 
					"4) All of us are subject to God\'s just condemnation", 
					"The wages of sin are death...\n\nRomans 6:23 (ESV)"));

			dictionary.Add (dKey[i++], 
				new Scripture("1 Timothy 1:15", 
					"5) God sent his only son Jesus to provide eternal life and joy", 
					"The saying is trustworthy and deserving of full acceptance, that Christ Jesus came into the world to save sinners\n\n1 Timothy 1:15 (ESV)"));

			dictionary.Add (dKey[i++], 
				new Scripture("Acts 3:19; 16:31", 
					"6) The benefits purchased by the death of Christ belong to those who repent and trust him", 
					"Repent therefore, and turn again, that your sins may be blotted out\n\nActs 3:19 (ESV)\n\nBelieve in the Lord Jesus and you will be saved\n\nActs 16:31 (ESV)"));

			dictionary.Add (dKey[i++], 
				new Scripture("",
					"What should you do?",
					"Turn from the deceitful promises of sin. Everyone who calls on the name of the Lord will be saved.\nRomans 10:13 (ESV)\n\nRead the Bible.\n\nPray.\n\nAttend a Bible-believing church."));

			parent = new StackLayout ();

			// Add heading
			Label heading = new Label { Text = "Quest for Joy", 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Bold };
			parent.Children.Add (heading);

			// Add buttons
			Button add;
			for (int j=0; j<i-1; j++) {
				add = new Button { Text = dictionary[dKey[j]].Reference() };
				add.Clicked += OnButtonClicked;
				parent.Children.Add (add);
			}
/*
			add = new Button { Text = dictionary[dKey[1]].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["Romans 3:23"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["Romans 6:23"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["1 Timothy 1:15"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);

			add = new Button { Text = dictionary["Acts 3:19; 16:31"].Reference() };
			add.Clicked += OnButtonClicked;
			parent.Children.Add (add);
*/
			add = new Button { Text = dictionary["What should you do?"].Heading() };
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

