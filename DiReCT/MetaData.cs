using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;


namespace DiReCT
{
    // An enumeration of disasters. Start at 1 (0 = uninitialized).
    public enum Disaster
    {
        // Disasters
        Flood = 1,
        Landslide,
        Fire,
    }
    
    // Metadata of disaster type
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class DisasterTypeAttribute : Attribute
    {
        // constructor
        public DisasterTypeAttribute(Disaster type)
        {
            theType = type;
        }
        protected Disaster theType;
        public Disaster Type
        {
            get { return theType; }
            set { theType = Type; }
        }
    }
    
    // Metadata of disaster data
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DisasterNameAttribute : Attribute
    {
        private string name;
        private string id;

        public DisasterNameAttribute(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public string Name
        { get; set; }
        public string ID
        { get; set; }
    }
    /*
    Metadata of disaster area
    Metadata of disaster date
    
        to be done.
    */
    
    // Metadata of recorder
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class RecorderAttribute : Attribute
    {
        private string name;
        private string organization;

        public RecorderAttribute(string name, string org)
        {
            this.name = name;
            this.organization = org;
        }
        public string Name
        { get; set; }
        public string Organization
        { get; set; } 
    }
    
    //Metadata of device
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DeviceAttribute : Attribute
    {
        // constructor
        public DeviceAttribute(String id)
        {
            this.id = id;
        }
        protected String id;
        public String DeviceID
        {
            get { return id; }
            set { id = DeviceID; }
        }
    }
}


