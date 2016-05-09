using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.ObjectModel.Metadata
{
    public class MRecord
    {
        // This Auto-property is a revision history of the Record.
        public string Revision { get; set; }

        // This Auto-property is a title of the Record.
        public string Title { get; set; }

        // This Auto-property is a group of the Record.
        public string Groups { get; set; }

        // This Auto-property is a tag of the Record.
        public string Tags { get; set; }

        // This Auto-property is a disaster name of the Record.
        public string DisasterName { get; set; }

        // This Auto-property is a disaster type of the Record.
        public string DisasterType { get; set; }
    }
}
