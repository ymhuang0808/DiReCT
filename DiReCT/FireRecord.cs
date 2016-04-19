using System;

namespace DiReCT
{
	public class FireRecord : ObservationDataRecord
	{
		//Constrants
		public const string disasterType = "Fire";

		// Public constructor.
		public FireRecord (string disasterName, string recorderName, string time)
		{
			UID = disasterType + "-" + disasterName + "-" + recorderName + "-" + time;
		}

	}
}

