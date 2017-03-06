using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (!(string.IsNullOrEmpty(value) || value.Length < 3))
                {
                    this.model = value;
                }
            }
        }

        public string Material
        {
            get
            {
                string newMaterial = this.material[0].ToString().ToUpper() + this.material.Substring(1);
                return newMaterial;
            }
            private set { this.material = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public decimal Height
        {
            get { return this.height; }
            internal set
            {
                if (!(value <= 0))
                {
                    this.height = value;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Model: {0}, Material: {1}, Price: {2}, Height: {3:0.00}, ", this.Model, this.Material, this.Price, this.Height);
        }
    }
}
