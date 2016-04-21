using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiReCT
{
        //each types of disaster interface
        //implement IRecord method in each class
        interface IDisaster
        {
            void Record();
        }
        public class LandslideRecord : IDisaster
        {
            
           enum LandslideDamage
           {
              Light,
              Medium,
              Severe
           }
           public void Record()
           {

           }
        }

        public class FloodRecord : IDisaster
        {
            enum Height
            {
                AnkleHigh,
                KneeHigh,
                ThighHigh,
                WaistHigh
            };

            public void Record()
            {

            }
        }
        public class FireRecord : IDisaster
        {
            enum FireDamage
            {
                Light,
                Medium,
                Severe
            }
            public void Record()
            {

            }
        }
       
}
