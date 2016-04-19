using System;

namespace DiReCT
{
	public class LandsideRecord : ObservationDataRecord
	{
		//Constrants
		public const string disasterType = "Landside";

		// Public constructor.
		public LandsideRecord (string disasterName, string recorderName, string time)
		{
			UID = disasterType + "-" + disasterName + "-" + recorderName + "-" + time;
		}
	}
}

