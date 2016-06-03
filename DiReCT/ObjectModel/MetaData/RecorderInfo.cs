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
 * 		RecorderInfo.cs
 *
 * Abstract:
 *
 *      RecorderInfo class is the model of observation record metadata.
 *      It contains members to store recorder information.
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
 * 		2016/06/01: add properties. 
 * 
 */
using System.Collections.Generic;

namespace DiReCT.ObjectModel
{
    public class RecorderInfo
    {
        /// <summary>
        /// This Auto-property is for accessing value of recorder name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of recorder ID.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of recorder organization.
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of recorder phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
       
        public Dictionary<string, string> Records;

        private Dictionary<string, string> Records2 { get; set; } = new Dictionary<string, string>();
    }
}
