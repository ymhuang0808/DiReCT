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
 * 		DestroyedObjectRecord.cs
 *
 * Abstract:
 *
 * 		DestroyObjectRecord  is a subclass inherited from ObservationRecord.
 *      It provides members for data captured such as destroyed houses, destroyed roads, etc.
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
 */

namespace DiReCT.ObjectModel
{
    class DestroyedObjectRecord : ObservationRecord
    {
        /// <summary>
        ///  This Auto-property is for storing the number of destroyed houses.
        /// </summary>
        public int DestroyedHouses { get; set; }


        /// <summary>
        ///  This Auto-property is for storing the number of destroyed roads.
        /// </summary>
        public int Destroyedroads { get; set; }



    }
}
