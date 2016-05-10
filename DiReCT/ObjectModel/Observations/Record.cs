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
using System.Device.Location;
using System.Diagnostics;

using DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Observations
{

    public abstract class Record
    {

        // This Auto-property is a identifier of the Record.
        // It is a combination of identifiers of disaster type,
        // disaster name, recorder name, time and date, and so on.
        public string UID { get; protected set; }

        // This Auto-property is a calendar time of the Record.
        public DateTime CalendarTime { get; set; }

        // This Auto-property is a calendar time of the Record.
        public Stopwatch MonotonicTime { get; set; }

        // Pointer to GeoCoordinate
        public GeoCoordinate Location;

        // Pointer to Disaster of ObservationRecordMetadata
        public Disaster Disaster;

        // Pointer to Recorder of ObservationRecordMetadata
        public Recorder Recorder;

        // Pointer to AdditionInfo of ObservationRecordMetadata
        public AdditionInfo AdditionInfo;

        // Pointer to Reference of ObservationRecordMetadata
        public Reference Reference;

        // This function is used to combine the UID.
        public void SetUID()
        {
            this.UID = Disaster.Type + "-" + Disaster.Name + "-" + Recorder.Name + "-" + this.CalendarTime.ToString("yyyyMMddHHmmssffff");
        }

        public Record(
            Disaster Disaster,
            Recorder Recorder
            )
        {
            this.Disaster = Disaster;
            this.Recorder = Recorder;
        }

    }
}

