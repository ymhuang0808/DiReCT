﻿/**
 * 
 * FloodRecord.cs is the class for "Flood Record" in the DiReCT.ObjectModel.Observations
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
 * 		FloodRecord.cs
 * 
 * Abstract:
 * 
 * 		FloodRecord is fire model and part of core data strcture, 
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
 * 		2016/4/20: Add a constructor
 * 
 */
using System;
using DRBoaST.DiSRC.DiReCT.ObjectModel.Metadata;

namespace DRBoaST.DiSRC.DiReCT.ObjectModel.Observations
{
	public class Flood : Record
	{
		//Constrants
		public const string disasterType = "Flood";

		// Public constructor.
		public Flood (
            Disaster Disaster,
            Recorder Recorder,
            DateTime recordTime
            ) : base (Disaster, Recorder)
		{
            Disaster.Type = Disaster.Type;

            Disaster.Name = Disaster.Name;
            Recorder.Name = Recorder.Name;

            this.CalendarTime = recordTime;

            SetUID();
        }
	}
}

