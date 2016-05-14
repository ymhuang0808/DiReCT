using System;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class Disaster : Attribute
    {
        private string name;
        private string type;
        private DateTime duration;
        private string area;
  
        public Disaster(string nm, string tp, DateTime du, string ar)
        {
            this.name = nm;
            this.type = tp;
            this.duration = du;
            this.area = ar;
        }
        public Disaster(string nm, string tp, string ar)
        {
            this.name = nm;
            this.type = tp;
            this.area = ar;
        }
        public Disaster(){}
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value; 
            }
        }
        public DateTime Duration
        {
            get
            {
                return duration;
            }
        }
        public string AffectedArea
        {
            get
            {
                return area;
            }
        }
    }
}
