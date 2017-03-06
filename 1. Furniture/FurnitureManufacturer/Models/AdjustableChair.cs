using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.type = ChairType.AdjustableChair;
        }

        public void SetHeight(decimal height)
        {
            if (height > 0)
            {
                this.Height = height;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
