using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        public readonly decimal initialHeight;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.initialHeight = height;
            this.type = ChairType.ConvertibleChair;
        }

        public bool IsConverted
        {
            get { return isConverted; }
            private set { isConverted = value; }
        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;

            if (this.IsConverted)
            {
                this.Height = (decimal)Math.Round(0.1, 2); ;
            }
            else
            {
                this.Height = this.initialHeight;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted " : "Normal");
        }
    }
}
