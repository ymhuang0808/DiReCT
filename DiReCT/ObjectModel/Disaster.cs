using System;

namespace DiReCT.ObjectModel
{
    public class Disaster
    {
        // This Auto-property is a disaster name of the Record.
        public string Name { get; set; }

        // This Auto-property is a disaster type of the Record.
        public string Type { get; set; }

        // This Auto-property is a duration of the Record.
        public DateTime Duration { get; set; }

        // This Auto-property is a affected area of the Record.
        public string AffectedArea { get; set; }

    }
}
