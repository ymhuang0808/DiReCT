using System;


namespace DiReCT.ObjectModel
{
	public class LandslideRecord : ObservationRecord
	{
		//Constrants
		public const string disasterType = "Landslide";

        // Public constructor.
        // Public constructor.
        public LandslideRecord(
            string eventName,
            string eventType,
            string recorderName,
            DateTime recordTime
            )
        {
            this.EventName = eventName;
            this.EventType = eventType;
            this.RecorderName = recorderName;
            this.RecordTime = recordTime;

            SetUID();
        }
    }
}

