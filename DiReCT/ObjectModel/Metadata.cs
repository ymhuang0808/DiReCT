using System;

namespace DiReCT.ObjectModel.Observations
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class Metadata : Attribute
    {
        public class DisasterType : Attribute
        {
            private string type;
            public DisasterType(string type)
            {
                this.type = type;
            }
            public string Type
            {
                get
                {
                    return type;
                }
            }
        }
        public class DisasterName : Attribute
        {
            private string name;
            public DisasterName(string name)
            {
                this.name = name;
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
        }
        public class DisasterDuration : Attribute
        {
            public DateTime time;
            public DisasterDuration(DateTime time)
            {
                this.time = time;
            }
            public DateTime Time
            {
                get
                {
                    return time;
                }
            }
            // Time duration function to be done.
        }
        public class DisasterLocation : Attribute
        {
            private string area;
            public DisasterLocation(string area)
            {
                this.area = area;
            }
            public string Area
            {
                get
                {
                    return area;
                }
            }
        }
        public class RecorderName : Attribute
        {
            private string name;
            public RecorderName(string name)
            {
                this.name = name;
            }
            public string Name
            {
                get
                {
                    return name;
                }
            }
        }
        public class RecorderOrganization : Attribute
        {
            private string org;
            public RecorderOrganization(string org)
            {
                this.org = org;
            }
            public string Organization
            {
                get
                {
                    return org;
                }
            }
        }
        public class Device : Attribute
        {
            private string id;
            public Device(string id)
            {
                this.id = id;
            }
            public string ID
            {
                get
                {
                    return id;
                }
            }
        }
    }
}
