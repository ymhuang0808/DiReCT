

namespace DiReCT.ObjectModel
{
    public class CasualtiesRecord : ObservationRecord
    {
        //
        // This Auto-property is for storing the number of death toll.
        //
        public int DeathToll { get; set; }

        //
        // This Auto-property is for storing the number of injuries.
        //
        public int Injuries { get; set; }

        //
        // This Auto-property is for storing the number of missing people.
        //
        public int MissingPeople { get; set; }


        // Constructor.
        public CasualtiesRecord(
            DeviceInfo DeviceInfo,
            RecorderInfo RecorderInfo
            ) : base(
                DeviceInfo,
                RecorderInfo
                )
        {
            this.EventType = "Casualties";
        }
    }
}
