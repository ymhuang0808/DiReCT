/**
 * Copyright (c) 2016 DRBoaST
 * 
 * Project Name:
 * 
 * 		DiReCT(Disaster Record Capture Tool)
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
 * 		ObservationRecord is a core data structrue in DiRecT, 
 * 		it provides members for data captured by time stamped,
 * 		location stamped.,etc. 
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
 * 		2016/5/19: Re-Design Data Structure based on Jane's suggestions. 
 * 
 */

using System;
using System.Collections.Generic;
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
        // This Auto-property is for storing sequence time stamps.
        //
        public DateTime TimeStamp { get; set; }


        //
        // This Auto-property is for storing posible reason of the damage.
        //
        public string Reason { get; set; }


        //
        // This Auto-property is for storing multiple Outliers.
        //
        public Boolean Outlier { get; set; }


        //
        // This Auto-property is for storing the name of the event.
        //
        public string EventName { get; set; }


        //
        // This Auto-property is for storing the type of the event.
        //
        public string EventType { get; protected set; }


        //
        // This Auto-property is for storing sequence location stamps.
        //
        public GeoCoordinate LocationStamp { get; set; }

        //
        // Declaring DeviceInfo to reference
        //
        public DeviceInfo DeviceInfo;

        //
        // Declaring RecorderInfo to reference
        //
        public RecorderInfo RecorderInfo;


        // To-Do: Links to audio & video     


        // This function is used to combine the UID.
        public void SetUID()
        {
            if (this.UID == null)
            {
                this.UID = EventType + "-" + EventName + "-" + TimeStamp.ToString("yyyyMMddHHmmss");
            }
            else
            {
                Console.WriteLine("Already has a UID");
            }
        }

        /// <summary>
        /// Assign values of parameters to observation data structure.
        /// 
        /// This constructor will be called by sub-class
        /// (for example, FireRecord, Floodrecord...)
        /// 
        /// @param DeviceInfo   - pointer to DeviceInfo
        /// @param RecorderInfo - pointer to RecorderInfo
        /// 
        /// </summary>
        public ObservationRecord(
            DeviceInfo DeviceInfo,
            RecorderInfo RecorderInfo

            )
        {
            this.DeviceInfo = DeviceInfo;
            this.RecorderInfo = RecorderInfo;
            
        }

    }
}

