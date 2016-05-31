using System;
using System.Device.Location;
using System.Diagnostics;
using System.Collections.Generic;

using DiReCT.ObjectModel;


namespace DiReCT
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            ObservationRecord flood = new FloodRecord() { EventName = "莫拉颱風" };

            Dictionary<string, ObservationRecord> floodRecordItems = new Dictionary<string, ObservationRecord>();

            floodRecordItems.Add(flood.UID, flood);

            foreach (var index in floodRecordItems )
            {
                Console.WriteLine("{0}, {1}", index.Key, index.Value);
            }
            Console.WriteLine();

            Console.ReadLine();
        }

	}
}
