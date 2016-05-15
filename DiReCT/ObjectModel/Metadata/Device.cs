using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DeviceAttribute : Attribute
    {
        public DeviceAttribute(string id)
        {
            this.ID = id;
        }
        public string ID
        {
            get;
            private set;
        }
    }
    [Device("Ipad Air 2")]
    public class Device
    {
        private string ID;
        public Device(string id)
        {
            this.ID = id;
        }
        public string deviceID
        {
            get
            {
                return ID;
            }
            set
            {
                this.ID = value;
            }
        }
    }
}
