using System;
using DiReCT.ObjectModel.Observations;

namespace DiReCT
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string now = GetTimestamp (DateTime.Now);

			Fire fireRecord = new Fire ("TaipeiStationFire", "Jim", now);
			Flood floodRecord = new Flood ("PuliFlood", "JohnsonS", now);
			Landside landsideRecord = new Landside ("ShiaoLinlandside", "JohnsonH", now);

			Console.WriteLine ("Call fire.UID    => {0}", fireRecord.UID);
			Console.WriteLine ("Call flood.UID   => {0}", floodRecord.UID);
			Console.WriteLine ("Call lanside.UID => {0}", landsideRecord.UID);
            Console.ReadLine();

		}

		public static String GetTimestamp (DateTime value)
		{
			return value.ToString ("yyyyMMddHHmmssffff");
		}
	}
}
