/**
 * 
 * ObservationRecord.cs is the abstract class for "Observation Record" in the DiReCT project. 
 * 
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
using DiReCT.ObjectModel.Metadata;

namespace DiReCT.ObjectModel
{

    public abstract class ObservationRecord
    {

        // This Auto-property is a identifier of the Record.
        // It is a combination of identifiers of disaster type,
        // disaster name, recorder name, time and date, and so on.
        public string UID { get; protected set; }

        public List<DateTime> TimeStamp { get; set; }

        public List<Boolean> Outlier { get; set; }

        // To-Do: Built-In Methods

        // To-Do: Links to audio & video     

        // This function is used to combine the UID.
        public void SetUID()
        {
            // this.UID = eventname + eventtype + recordername + Timestamp

        }

      

    }
}

