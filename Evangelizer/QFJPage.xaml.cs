using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class QFJPage : ContentPage
	{	
		Dictionary<string, Scripture> dictionary =
			new Dictionary<string, Scripture>();
/*
		string [] dKey = new string[] {
			"Isaiah 43:6–7", 
			"1 Corinthians 10:31", 
			"Romans 3:23",
			"Romans 6:23", 
			"1 Timothy 1:15", 
			"Acts 3:19; 16:31", 
			"What should you do?"};
*/
		string [] dKey = new string[] {
			"1) God created us for his glory", 
			"2) Every human should live for God's glory", 
			"3) All of us have failed to glorify God as we should",
			"4) All of us are subject to God's just condemnation", 
			"5) God sent his only son Jesus to provide eternal life and joy", 
			"6) The benefits purchased by the death of Christ belong to those who repent and trust him", 
			"What should you do?"};

		ScrollView scroll;
		StackLayout stack;

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

			stack = new StackLayout ();
			scroll = new ScrollView ();

			stack.Padding = 20;
			stack.Spacing = 10;

			// Add heading
			Label heading = new Label { Text = "Quest for Joy", 
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				FontAttributes = FontAttributes.Bold };
			stack.Children.Add (heading);

			// Add labels with tap gesture recognizers
			var tapGestureRecognizer = new TapGestureRecognizer();
			tapGestureRecognizer.Tapped +=(s,e)=>OnLabelTapped(s,e);

			Label label;
			for (int j=0; j<i; j++) {
				label = new Label { Text = dictionary[dKey[j]].Heading() };
//				add.Clicked += OnButtonClicked;
				label.GestureRecognizers.Add(tapGestureRecognizer);
				stack.Children.Add (label);
			}
/*
			Button add = new Button { Text = dictionary["What should you do?"].Heading() };
			add.Clicked += OnButtonClicked;
			stack.Children.Add (add);
*/
			scroll.Content = stack;
			Content = scroll;

		}

		async void OnLabelTapped(object sender, EventArgs args)
		{
			Label l = (Label)sender;
			await this.Navigation.PushAsync(new TestVersePage(dictionary[l.Text]));
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			// Navigate to a new page to display the verse
			await this.Navigation.PushAsync(new TestVersePage(dictionary[button.Text]));
		}
	}
}

