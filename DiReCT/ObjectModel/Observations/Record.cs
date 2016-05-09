/**
 * 
 * ObservationDataRecord.cs is the abstract class for "Record" in the DiReCT.ObjectModel.Observations
 * project. 
 * 
 * Copyright (c) 2016 DRBoaST
 * 
 * Project Name:
 * 
 * 		DiReCT.ObjectModel.Observations(Disaster Record Capture Tool)
 * 
 * Version:
 * 
 * 		1.0
 * 
 * File Name:
 * 
 * 		ObservationDataRecord.cs
 * 
 * Abstract:
 * 
 * 		ObservationDataRecord is a core data structrue, 
 * 		it is designed to interact with other states and flows.
 * 
 * Authors:
 * 
 * 		Johnson Su, johnsonsu@iis.sinica.edu.tw
 * 
 * License:
 * 
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 * Major Revisions:
 * 	
 * 		2016/4/20: Add a member "UID"
 * 		2016/4/27: 
 * 
 */

using System;
using DiReCT.ObjectModel.Metadata;

namespace DiReCT.ObjectModel.Observations
{

	public abstract class Record
	{

		// This Auto-property is a identifier of the Record.
		// It is a combination of identifiers of disaster type,
		// disaster name, recorder name, time and date, and so on.
		public string UID{ get; protected set; }

		// This Auto-property is a record time of the Record.
		public string RecordTime{ get; set; }

		// This Location object is a Struct(value-type) object
		// It contains longitude, Latitude and Altitude members.
		public struct Location
		{
			public double Longitude{ get; set; }

			public double Latitude{ get; set; }

			public double Altitude{ get; set; }
		}

        // Pointer to MetadataRecord
        public MRecord MRecord;

        // Pointer to MetadataRecorder

        public MRecorder MRecorder;

        public class Observations
		{
			// To-Do 
		}

		// This function is used to combine the UID.
		public void SetUID ()
		{
			this.UID = MRecord.DisasterType + "-" + MRecord.DisasterName + "-" + MRecorder.Name + "-" + this.RecordTime;

		}

        public Record(
            MRecord MRecord,
            MRecorder MRecorder
            ) {
            this.MRecord = MRecord;
            this.MRecorder = MRecorder;
        }

	}
}

