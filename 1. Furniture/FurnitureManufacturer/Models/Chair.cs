using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public enum ChairType
    {
        Chair,
        AdjustableChair,
        ConvertibleChair
    }

    public class Chair : Furniture, IChair
    {
        internal ChairType type; 
        private int numberOfLegs;

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
            this.type = ChairType.Chair;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set { this.numberOfLegs = value; }
        }

        public override string ToString()
        {
            string baseToString = base.ToString();
            return string.Format("Type: {0}, ", this.type.ToString()) + baseToString + string.Format("Legs: {0}", this.NumberOfLegs);
        }
    }
}
