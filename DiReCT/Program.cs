using System;
using DiReCT.ObjectModel.Observations;
using DiReCT.ObjectModel.Metadata;

namespace DiReCT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string now = GetTimestamp(DateTime.Now);
            MRecord mRecord = new MRecord();
            MRecorder mRecorder = new MRecorder();

            Fire fireRecord = new Fire("TaipeiStationFire", "Jim", now, mRecord, mRecorder);
            Flood floodRecord = new Flood("PuliFlood", "JohnsonS", now, mRecord, mRecorder);
            Landside landsideRecord = new Landside("ShiaoLinlandside", "JohnsonH", now, mRecord, mRecorder);

            Console.WriteLine("Call fire.UID    => {0}", fireRecord.UID);
            Console.WriteLine("Call flood.UID   => {0}", floodRecord.UID);
            Console.WriteLine("Call lanside.UID => {0}", landsideRecord.UID);
            Console.ReadLine();

        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
    }
}
