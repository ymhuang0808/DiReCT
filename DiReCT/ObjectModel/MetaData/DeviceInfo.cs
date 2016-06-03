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
 * 		DeviceInfo.cs
 *
 * Abstract:
 *
 * 		DeviceInfo class is the model of observation record metadata.
 *      It contains members to store device information.
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
namespace DiReCT.ObjectModel
{
    public class DeviceInfo
    {
        /// <summary>
        /// This Auto-property is for accessing value of device model number.
        /// </summary>
        public string DeviceModelNumber { get; set; }

        /// <summary>
        /// This Auto-property is for accessing value of device IMEI.
        /// </summary>
        public string DeviceIMEI { get; set; }
    }
}
