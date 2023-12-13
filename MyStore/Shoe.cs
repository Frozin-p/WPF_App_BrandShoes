using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    internal class Shoe
    {
        public int id { get; set; }
        private int price;
        private string brand, model;

        public int Price 
        { 
            get { return price; } 
            set { price = value; } 
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Shoe() { }

        public Shoe(int price, string brand, string model, string description)
        {
            this.price = price;
            this.brand = brand;
            this.model = model;
        }
    }
}
