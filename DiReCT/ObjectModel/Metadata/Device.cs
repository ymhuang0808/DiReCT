using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata
{
    public class Device
    {
        // This Auto-property is a Model of the Deivce.
        public string Model { get; set; }

        // This Auto-property is a IMEI code of the Deivce.
        public string IMEI { get; set; }

        // This Auto-property is a Serial Number of the Deivce.
        public string SerialNumber { get; set; }
    }
}
