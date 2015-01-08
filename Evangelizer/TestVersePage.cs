﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evangelizer
{	
	public partial class TestVersePage : ContentPage
	{	
		public static Scripture scripture;

		public TestVersePage (Scripture s)
		{
			//InitializeComponent ();
			scripture = s;

			this.Content = new StackLayout {
				Spacing = 10, Padding = 20,
				VerticalOptions = LayoutOptions.Start,
				Children = {
					new Label { Text = scripture.Heading() }, //, Font=Font.SystemFontOfSize(20, FontAttributes.Bold) },
					new Label { Text = scripture.Verse() } //, Font = Font.SystemFontOfSize(FontAttributes.Italic) },
					//new Label { Text = scripture.Reference() }
				}
			};
		}

	}
}

