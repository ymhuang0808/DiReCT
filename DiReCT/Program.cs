using System;
using System.Device.Location;
using System.Diagnostics;

using DRBoaST.DiSRC.DiReCT.ObjectModel.Observations;
using DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata;

namespace DiReCT
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            System.Reflection.MemberInfo info = typeof(Device);
            object[] attributes;
            attributes = info.GetCustomAttributes(typeof(DeviceAttribute), false);
            foreach (Object attribute in attributes)
            {
                DeviceAttribute dvc = (DeviceAttribute)attribute;
                Console.WriteLine("Device: {0}", dvc.ID);
            }
                     
            /*
            DateTime now = DateTime.Now;

            Disaster disaster = new Disaster();
            Recorder recorder = new Recorder();

            disaster.Type = "Fire";
            disaster.Name = "TaipeiStation";

            recorder.Name = "Jeff";

            Fire fireRecord = new Fire(disaster, recorder, now);

            
            GeoCoordinate location = new GeoCoordinate();
            location.Longitude = 120.0000;
            location.Latitude = 21.00010;
            location.Altitude = 10.01;
            

            Console.WriteLine ("Call fire.UID    => {0}", fireRecord.UID);
            Console.ReadLine();
            */
        }

	}
}
