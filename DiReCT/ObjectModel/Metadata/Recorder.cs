using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple =true)]
    public class Recorder : Attribute
    {
        private string name;
        private string organization;
        public Recorder(string nm, string org)
        {
            this.name = nm;
            this.organization = org;
        }
        public Recorder(string nm)
        {
            this.name = nm;
        }
        public Recorder() { }
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
        public string Organization
        {
            get
            {
                return organization;
            }
        }
    }
}
