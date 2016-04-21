using System;

namespace DiReCT
{
	public abstract class ObservationDataRecord
	{
		// This Read-only property is a identifier of the Record.
		// It is a combination of identifiers of disaster type,
		// disaster name, recorder name, time and date, and so on.
		public string UID{ get; protected set; }

        // Time class to be done.
        // Location class to be done.
        //Effected ared to be done
        private string recorderID;
        private string recorderOrganization;
        private string device;
        private int deaths;
        private int injuries;
        public BuildingDamage degree { get; set; }
        public enum BuildingDamage
        {
            Light,
            Medium,
            Severe,
        }
        public int Deaths
        {
            get { return deaths; }
            set { this.deaths = value; }
        }
        public int Injuries
        {
            get { return injuries; }
            set { this.injuries = value; }
        }
        public string RecorderID
        {
            get { return recorderID; }
            set { this.recorderID = value; }
        }
        public string RecorderOrganization
        {
            get { return recorderOrganization; }
            set { this.recorderOrganization = value; }
        }
        public string Device
        {
            get { return device; }
            set { this.device = value; }
        }

	}
}

