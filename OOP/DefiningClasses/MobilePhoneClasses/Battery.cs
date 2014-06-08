namespace MobilePhoneClasses
{
    using System;

    //3. Add an enumeration BatteryType
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
        LiPoly,
    }

    internal class Battery //1. Define battery class. Battery characteristics(model, hours idle and hours talk)
    {
        private string batteryModel;
        private BatteryType batType; //3. use enumeration as a new field for the batteries.

        public Battery(string batteryModel, ulong hoursIdle, ulong hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string batteryModel, ulong hoursIdle, ulong hoursTalk, BatteryType batType)
            : this(batteryModel, hoursIdle, hoursTalk)
        {
            this.batType = batType;
        }

        //5. Use properties to encapsulate the data fields inside battery
        public string BatteryModel
        {
            get 
            {
                return this.batteryModel;
            }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("The battery model should be at least 3 letters");
                }
                else
                {
                    this.batteryModel = value;
                }
            }
        }
        public ulong HoursIdle { get; set; }
        public ulong HoursTalk { get; set; }

        public override string ToString()
        {
            return string.Format("Battery model: {0}\nBattery hours idle: {1}\nBattery hours talk: {2}", this.BatteryModel, this.HoursIdle, this.HoursTalk);
        }
    }
}
