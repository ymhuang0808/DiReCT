using System;

namespace DiReCT
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string now = GetTimestamp (DateTime.Now);

			FireRecord fire = new FireRecord ("momo", "Johnson", now);
			FloodRecord flood = new FloodRecord ("YOKOHAMA", "Jeff", now);
			LandsideRecord Landside = new LandsideRecord ("JakeLee", "YM", now);

			Console.WriteLine ("Hello World!");
			Console.WriteLine (fire.UID);
			Console.WriteLine (flood.UID);
			Console.WriteLine (Landside.UID);


		}

		public static String GetTimestamp (DateTime value)
		{
			return value.ToString ("yyyyMMddHHmmssffff");
		}
	}
}
