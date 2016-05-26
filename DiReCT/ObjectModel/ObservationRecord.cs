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
 * 		ObservationRecord.cs
 * 
 * Abstract:
 * 
 * 		ObservationRecord is a abstract class which contains all mutual observation record.
 * 		This class will not implement and will be inherited by others subclass. 
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
using System.Device.Location;



namespace DiReCT.ObjectModel
{
    public abstract class ObservationRecord
    {
        //
        // This Auto-property is a identifier of the ObservationRecord.
        //
        public string UID { get; protected set; }


        //
        // This Auto-property is a calendar time of the ObservationRecord.
        //
        public DateTime RecordTime { get; set; }


        //
        // Pointer to GeoCoordinate
        //
        public GeoCoordinate Location;


        //
        // This method uses to combine the UID.
        // It is a combination of identifiers of event type,
        // event name, recorder name, time and date and so on.
        //
        public void SetUID()
        {
            this.UID = EventName + "-" + EventType + "-" + RecorderName + "-" + this.RecordTime.ToString("yyyyMMddHHmmssffff");
        }


        //
        // This Auto-property is a event name of the ObservationRecord.
        //
        public string EventName { get; set; }


        //
        // This Auto-property is a event type of the ObservationRecord.
        //
        public string EventType { get; set; }
        

        //
        // This Auto-property is a event duration of the ObservationRecord.
        //
        public DateTime EventDuration { get; set; }
        
        
        //
        // This Auto-property is a event affected area of the ObservationRecord.
        //
        public string EventAffectedArea { get; set; }

        
        //
        // This Auto-property is a device model of the  ObservationRecord.
        //
        public string DeviceModel { get; set; }

        
        //
        // This Auto-property is a device IMEI code of the  ObservationRecord.
        //
        public string DeviceIMEI { get; set; }

        
        //
        // This Auto-property is a device Serial Number of the  ObservationRecord.
        //
        public string DeviceSerialNumber { get; set; }

        
        //
        // This Auto-property is a recorder name of the  ObservationRecord.
        //
        public string RecorderName { get; set; }

        
        //
        // This Auto-property is a recorder organization of the  ObservationRecord.
        //
        public string RecorderOrganization { get; set; }

        
        //
        // This boolean property returns whether is a outlier.
        //
        public bool IsOutlier = true;



    }
}

