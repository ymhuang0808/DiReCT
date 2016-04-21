using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT
{
        //each types of disaster interface
        //implement IRecord method in each class
        interface DeisasterInterface
        {
            void IRecord();
        }
        public class LandslideRecord : DisasterInterface
        {
            
           enum LandslideDamage
           {
              Light,
              Medium,
              Severe
           }
           public void IRecord()
           {

           }
        }
        
        public class FloodRecord : DisasterInterface
        {
            enum Height
            {
                AnkleHigh,
                KneeHigh,
                ThighHigh,
                WaistHigh
            };

            public void IRecord()
            {

            }
        }
        public class FireRecord : DisasterInterface
        {
            enum FireDamage
            {
                Light,
                Medium,
                Severe
            }
            public void IRecord()
            {

            }
        }
       
}
