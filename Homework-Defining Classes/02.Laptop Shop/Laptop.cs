using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string hdd;
        private string graphicsCard;
        private Battery battery;
        private string screen;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null, string hdd = null, string graphicsCard = null, Battery battery = null, string screen = null)
            : this(model, price)
        {

        
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.Screen = screen;
        }
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for manufacturer!");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for processor!");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get { return this.ram; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for ram!");
                }
                this.ram = value;
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for hdd!");
                }
                this.hdd = value;
            }
        }
        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for graphicsCard!");
                }
                this.graphicsCard = value;
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null && value.Length < 0)
                {
                    throw new ArgumentException("Invalid value for screen!");
                }
                this.screen = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid value for price!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("model: "+this.Model);
            if (this.Manufacturer != null)
            {
                sb.AppendLine("manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                sb.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                sb.AppendLine("ram: " + this.Ram);
            }
            if (this.Hdd != null)
            {
                sb.AppendLine("hdd: " + this.Hdd);
            }
            if (this.GraphicsCard != null)
            {
                sb.AppendLine("graphics card: " + this.GraphicsCard);
            }
            if (this.Battery != null)
            {
                sb.AppendLine("battery: " + this.Battery);
            }
            if (this.Screen != null)
            {
                sb.AppendLine("screen: " + this.Screen);
            }
                sb.AppendLine("price: " + this.Price);
            
            return sb.ToString();
        }
    }
}
