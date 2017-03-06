using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get { return this.length; }
            private set { this.length = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public decimal Area
        {
            get { return this.Length * this.Width; }
        }

        public override string ToString()
        {
            string baseToString = base.ToString();
            return string.Format("Type: Table, " + baseToString + string.Format("Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area));
        }
    }
}
