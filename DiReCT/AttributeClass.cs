using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace DiReCT
{
    /// <summary>
    /// Data of Recorder
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    [Recorder("Jeff", "IIS", "Sony-X1")]
    public class RecorderAttribute : Attribute
    {
        public RecorderAttribute(string id, string organization, string device)
        {
            this.RecorderID = id;
            this.RecorderOrganization = organization;
            this.Device = device;
        }
        public string RecorderID { get; set; }
        public string RecorderOrganization { get; set; }
        public string Device { get; set; }
        public string Comment { get; set; }

    }
    /// <summary>
    /// Record Disaster Names and types
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    [Record("DUJUAN", "Typhoon", "Taipei City")]
    public class RecordAttribute : Attribute
    {
        public RecordAttribute(string name, string type, string area)
        {
            this.Name = name;
            this.Type = type;
            this.Area = area;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string Comment { get; set; }
    }
    /// <summary>
    ///  Record Time
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    [Datetime(2016, 04, 15)]
    [Datetime("2016/04/15")]
    public class DatetimeAttribute : Attribute
    {
        private DateTime _date;
        public DatetimeAttribute(int year, int month, int day)
        {
            _date = new DateTime(year, month, day);
        }
        public DatetimeAttribute(string date)
        {
            _date = DateTime.Parse(date);
        }
        public DateTime Date
        {
            get { return _date; }
        }
        public bool IsAfterToday()
        {
            return this.Date > DateTime.Today;
        }
    }
    class print
    {
       /// Time to be done.
/*
            DateTime gtm = new DateTime(1970, 1, 1);
            DateTime utc = DateTime.UtcNow.AddHours(8);
            int timestamp = Convert.ToInt32(((TimeSpan)utc.Subtract(gtm)).TotalSeconds);
            double test = (DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DateTime tt = (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(timestamp);
            DateTime test2 = (new DateTime(1970, 1, 1, 0, 0, 0)).AddSeconds(test);
            Console.WriteLine(timestamp);
            Console.WriteLine(test);
            Console.WriteLine(tt);
            Console.WriteLine(test2); */
        
    }
}
