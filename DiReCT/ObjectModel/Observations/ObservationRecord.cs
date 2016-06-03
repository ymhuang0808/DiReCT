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
 *      ObservationRecord is an abstract class which contains basic members 
 *      for data captured by time stamped, location stamped, etc. 
 *
 * 		This class can not be instantiated and can be inherited by others subclasses. 
 *
 *
 * Authors:
 * 
 * 		Johnson Su, johnsonsu@iis.sinica.edu.tw
 *      Jeff Chen, jeff@iis.sinica.edu.tw
 * 
 * License:
 * 
 * 		GPL 3.0 This file is subject to the terms and conditions defined
 * 		in file 'COPYING.txt', which is part of this source code package.
 * 
 * Major Revisions:
 * 	
 * 		2016/04/20: Add a member "UID"
 * 		2016/06/01: Redesign data structure. 
 * 
 */

using System;
using System.Collections.Generic;
using System.Device.Location;


namespace DiReCT.ObjectModel
{

    public abstract class ObservationRecord
    {
        /// <summary>
        /// This property is for accessing value of UID.
        /// The UID is a identifier of the ObservationRecord.
        /// </summary>
        public string UID
        {
            get
            {
                return this.UID;
            }

            // This method is used to combine the UID.
            protected set
            {
                this.UID = EventType + "-" + EventName + "-" + TimeStamp.ToString("yyyyMMddHHmmss");
            }
        }


        /// <summary>
        /// This Auto-property is for accessing value of timestamp.
        /// </summary>
        public DateTime TimeStamp { get; set; }


        /// <summary>
        /// This Auto-property is for accessing value of possible damage reason.
        /// </summary>
        public List<string> Reasons { get; set; }


        /// <summary>
        /// This Auto-property is for accessing value of outlier.
        /// </summary>
        public Boolean Outlier { get; set; } = false;


        /// <summary>
        /// This Auto-property is for accessing value of event name.
        /// </summary>
        public string EventName { get; set; }


        /// <summary>
        /// This Auto-property is for accessing value of event type.
        /// </summary>
        public string EventType { get; protected set; }


        /// <summary>
        /// This Auto-property is for accessing value of location stamp.
        /// </summary>
        public GeoCoordinate LocationStamp { get; set; }


        ///
        /// To-Do: Links to audio & video.     
        ///

    }
}

