using System;


namespace DiReCT.ObjectModel
{
	public class FloodRecord : ObservationRecord
	{
		//Constrants
		public const string disasterType = "Flood";

		// Public constructor.
		public FloodRecord (
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

