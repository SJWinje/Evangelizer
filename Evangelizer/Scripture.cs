using System;

namespace Evangelizer
{
	public class Scripture
	{
		string reference;
		string heading;
		string verse;

		public Scripture (string r, string h, string v)
		{
			this.reference = r;
			this.heading = h;
			this.verse = v;
		}

		public string Reference ()
		{
			return reference;
		}
		public string Heading ()
		{
			return heading;
		}
		public string Verse ()
		{
			return verse;
		}
	}
}

