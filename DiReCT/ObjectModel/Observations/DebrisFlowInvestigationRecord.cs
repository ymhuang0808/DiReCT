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
 * 		DebrisFlowInvestigationRecord.cs
 *
 * Abstract:
 *
 *      DebrisFlowInvestigationRecord.cs is a subclass 
 *      inherited from ObservationRecord.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.ObjectModel
{
    class DebrisFlowInvestigationRecord : ObservationRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public string AdministrativeArea { get; set; }

        // <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RivuletCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RivuletName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HistoricalDamage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float CatchmentArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int SlopeOfUpperStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CollapseRateOfCatchmentArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RockyParticleSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        enum VegetationType
        {
            None,
            Meadow,
            Plantation,
            NaturalForest
        }

        /// <summary>
        /// 
        /// </summary>
        enum ScaleCollapse
        {
            None,
            Small,
            Large
        }

        /// <summary>
        /// 
        /// </summary>
        enum RivuletDamageType
        {
            SoilErosion,
            DebrisSlide,
            ShallowSlide,
            Other
        }

        /// <summary>
        /// 
        /// </summary>
        enum PossibleReasons
        {
            Typhoon,
            HeavyRainfall,
            Other
        }

    }
}
