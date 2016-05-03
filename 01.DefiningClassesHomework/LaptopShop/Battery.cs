using System;

namespace LaptopShop
{
    public class Battery
    {
        private string description;
        private double batteryLife;

        public Battery(string description, double batteryLife)
        {
            this.Description = description;
            this.BatteryLife = batteryLife;
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Battery description cannot be null or empty.");
                }
                this.description = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be a negative number.");
                }
                this.batteryLife = value;
            }
        }
    }
}