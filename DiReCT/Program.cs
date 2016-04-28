using System;

namespace DiReCT
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string now = GetTimestamp (DateTime.Now);

			FireRecord fireRecord = new FireRecord ("TaipeiStationFire", "Jim", now);
			FloodRecord floodRecord = new FloodRecord ("PuliFlood", "JohnsonS", now);
			LandsideRecord landsideRecord = new LandsideRecord ("ShiaoLinlandside", "JohnsonH", now);

			Console.WriteLine ("Call fire.UID    => {0}", fireRecord.UID);
			Console.WriteLine ("Call flood.UID   => {0}", floodRecord.UID);
			Console.WriteLine ("Call lanside.UID => {0}", landsideRecord.UID);

		}

		public static String GetTimestamp (DateTime value)
		{
			return value.ToString ("yyyyMMddHHmmssffff");
		}
	}
}
