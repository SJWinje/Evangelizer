using System;
using Xamarin.Forms;

namespace Evangelizer
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage(new MainPage());
		}
	}
}

