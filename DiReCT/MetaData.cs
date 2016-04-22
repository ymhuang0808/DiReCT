using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace DiReCT
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    // [Record("Flood001","Flood","2016/02/12","Taipei",2,1,"Jeff","IIS","Ipad2", "Flooding of inter state 280 NorthBound off ramp reported. ")]
    public class RecordAttribute : Attribute
    {
        public RecordAttribute()
        {

        }
    }
    public class RecorderAttribute : Attribute
    {

        public RecorderAttribute()
        {

        }
    }
    public class AdviceAttibute : Attribute
    {

    }
}
     /*   public RecordAttribute(string name, string type, string date, string area, int deaths, int injuries, string recorder, string org, string device, string narrative)
        {
            this.DisasterName = name;
            this.DisasterType = type;
            this.DisasterArea = area;
            this.DisasterDate = date;
            this.DisasterDeaths = deaths;
            this.DisasterInjuries = injuries;
            this.DisasterNarrative = narrative;
            this.Recorder = recorder;
            this.RecorderOrganization = org;
            this.Device = device;                     
        }
        
            //Record Metadata
            public string DisasterName { get; set; }
            public string DisasterType { get; set; }
            //a referece from CAP 
            //"\d\d\d\d-\d\d-\d\dT\d\d:\d\d:\d\d[-,+]\d\d:\d\d"/
            public string DisasterDate { get; set; }
            public string DisasterArea { get; set; }
            public int DisasterDeaths { get; set; }
            public int DisasterInjuries { get; set; }
            public string DisasterNarrative { get; set; }
            //Recorder Metadata
            public string Recorder { get; set; }
            public string RecorderOrganization { get; set; }
            public string Device { get; set; }
        

    }*/

