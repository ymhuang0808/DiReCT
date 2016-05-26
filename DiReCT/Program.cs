using System;
using System.Device.Location;
using System.Diagnostics;


namespace DiReCT.ObjectModel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            DateTime now = DateTime.Now;

            ObservationRecord fireRecord = new FireRecord("Nangkang village","fire","jeff",now);
            
          

            /*
            GeoCoordinate location = new GeoCoordinate();
            location.Longitude = 120.0000;
            location.Latitude = 21.00010;
            location.Altitude = 10.01;
            */

            Console.WriteLine ("Call fire.UID    => {0}", fireRecord.UID);
            Console.ReadLine();

        }

	}
}
