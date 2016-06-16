using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT.ObjectModel
{
    class DebrisFlowRecord : ObservationRecord
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
        public string Description { get; set; }

        
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
