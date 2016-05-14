using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class Device : Attribute
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
        }
    }
}
