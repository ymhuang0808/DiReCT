

namespace DiReCT.ObjectModel
{
    class DestroyObjectRecord : ObservationRecord
    {
        //
        // This Auto-property is for storing the number of destroyed houses.
        //
        public int DestroyedHouses { get; set; }


        //
        // This Auto-property is for storing the number of destroyed roads.
        //
        public int Destroyedroads { get; set; }


        // Constructor.
        public DestroyObjectRecord(
            DeviceInfo DeviceInfo,
            RecorderInfo RecorderInfo
            ) : base(
                DeviceInfo,
                RecorderInfo
                )
        {
            this.EventType = "DestroyObject";
        }
    }
}
