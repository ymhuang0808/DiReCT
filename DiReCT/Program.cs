using System;
using System.Device.Location;
using System.Collections.Generic;
using DiReCT.ObjectModel;


namespace DiReCT
{
	class MainClass
	{
        /// <summary>
        /// 
        /// In this example, we use flood scenario to illustrate 
        /// how to manipulate floodRecord.
        /// 
        /// </summary>
        /// <param name="args"></param>
		public static void Main (string[] args)
		{
            // create a instance of DeviceInfo
            //DeviceInfo deviceInfo = new DeviceInfo();

            // create a instance of DeviceInfo
            RecorderInfo recorderInfo = new RecorderInfo();

            Dictionary<string, string> testRecord = new Dictionary<string, string>();

            recorderInfo.Records = testRecord;

            recorderInfo.Records.Add("asdf", "asdf");

            recorderInfo.Records2.Add("asdfg", "asdfg");


            Console.WriteLine(recorderInfo.Records.ToString());
            Console.ReadLine();

            //// create a instance of FloodRecord
            //FloodRecord flood = new FloodRecord(deviceInfo, recorderInfo);

            //// adding event name to flood record
            //flood.EventName = "莫拉颱風";

            //// adding device information to flood record
            //flood.DeviceInfo.DeviceIMEI = "357631050052050";
            //flood.DeviceInfo.DeviceModelNumber = "Surface Pro 4";

            //// adding recorder information to flood record
            //flood.RecorderInfo.Name = "Johnson";
            //flood.RecorderInfo.Organization = "竹崎鄉公所";
            //flood.RecorderInfo.PhoneNumber = "0988555444";

            //// add the possible reason to flood record
            //flood.Reason = "河堤倒灌";

            //// adding a coordiate to flood record
            //flood.LocationStamp = new GeoCoordinate(23.525708, 120.552750); 

            //// adding the current time stamp to flood record
            //flood.TimeStamp = DateTime.UtcNow;

            //// generate the UID of flood record 
            //flood.SetUID();

            //// instance a Dictionary Data Structure for storing observation records
            //Dictionary<string, ObservationRecord> floodRecordItems = new Dictionary<string, ObservationRecord>();

            //// add a flood record to Dictionary
            //floodRecordItems.Add(flood.UID, flood);

            //// printing all properties of the flood record from dictionary  
            //foreach (var index in floodRecordItems )
            //{
            //    Console.WriteLine("{0}, {1}", index.Key, index.Value);

            //    Console.WriteLine("LocationStamp.Latitude: {0}", index.Value.LocationStamp.Latitude);
            //    Console.WriteLine("LocationStamp.Longitude: {0}", index.Value.LocationStamp.Longitude);
            //    Console.WriteLine("TimeStamp: {0}", index.Value.TimeStamp);

            //    Console.WriteLine("Reason: {0}", index.Value.Reason);
            //    Console.WriteLine("Outlier: {0}", index.Value.Outlier);

            //    Console.WriteLine("EventName: {0}", index.Value.EventName);
            //    Console.WriteLine("EventType: {0}", index.Value.EventType);

            //    Console.WriteLine("RecorderName: {0}", index.Value.RecorderInfo.Name);
            //    Console.WriteLine("RecorderPhoneNumber: {0}", index.Value.RecorderInfo.PhoneNumber);

            //    Console.WriteLine("DeviceIMEI: {0}", index.Value.DeviceInfo.DeviceIMEI);
            //    Console.WriteLine("DeviceModelNumber: {0}", index.Value.DeviceInfo.DeviceModelNumber);


            //}
            //Console.ReadLine();
        }

	}
}
