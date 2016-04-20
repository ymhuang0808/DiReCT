using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace DiReCT
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    [Record("Flood001","Flood","2016/02/12","Taipei",2,1,"Jeff","IIS","Ipad2")]
    public class RecordAttribute : Attribute
    {
        public RecordAttribute(string name, string type, string date, string area, int deaths, int injuries, string recorder, string org, string device)
        {
            this.DisasterName = name;
            this.DisasterType = type;
            this.DisasterArea = area;
            this.DisasterDate = date;
            this.DisasterDeaths = deaths;
            this.DisasterInjuries = injuries;
            this.Recorder = recorder;
            this.RecorderOrganization = org;
            this.Device = device; 
            
        }
            //Record Metadata
            public string DisasterName { get; set; }
            public string DisasterType { get; set; }
            public string DisasterDate { get; set; }
            public string DisasterArea { get; set; }
            public int DisasterDeaths { get; set; }
            public int DisasterInjuries { get; set; }
            //Recorder Metadata
            public string Recorder { get; set; }
            public string RecorderOrganization { get; set; }
            public string Device { get; set; }
        

    }
}
