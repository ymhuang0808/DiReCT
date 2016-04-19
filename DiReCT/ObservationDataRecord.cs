using System;

namespace DiReCT
{
	public abstract class ObservationDataRecord
	{
		// This Read-only property is a identifier of the Record.
		// It is a combination of identifiers of disaster type,
		// disaster name, recorder name, time and date, and so on.
		public string UID{ get; protected set; }


	}
}

