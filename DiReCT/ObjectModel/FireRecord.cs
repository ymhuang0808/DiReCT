using System;


namespace DiReCT.ObjectModel
{
	public class FireRecord : ObservationRecord
	{
		//Constrants
		public const string disasterType = "Fire";

        // Public constructor.
        public FireRecord(
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

