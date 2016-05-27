/**
 * Copyright (c) 2016 DRBoaST
 * 
 * Project Name:
 * 
 * 		DiReCT (Disaster Record Capture Tool)
 * 
 * Version:
 * 
 * 		1.0
 * 
 * File Name:
 * 
 * 		FireRecord.cs
 * 
 * Abstract:
 * 
 * 		FireRecord is a subclass which inherites abstract class.
 * 		This class will implement more specific observation properties.
 * 
 * Authors:
 * 
 * 		Johnson Su, johnsonsu@iis.sinica.edu.tw
 *		Jeff Chen, jeff@iis.sinica.edu.tw 
 *
 * License:
 * 
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 * Major Revisions:
 * 	
 * 		
 * 		
 * 
 */
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

