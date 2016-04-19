using System;

namespace DiReCT
{
	public class FloodRecord : ObservationDataRecord
	{
		//Constrants
		public const string disasterType = "Flood";

		// Public constructor.
		public FloodRecord (string disasterName, string recorderName, string time)
		{
			UID = disasterType + "-" + disasterName + "-" + recorderName + "-" + time;
		}
	}
}

