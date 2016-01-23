using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Laptop_Shop
{

    class Battery
    {
        public string type;
        public float hoursLife;

        public Battery(string type)
        {
            this.type = type;
        }
        public Battery(string type,float hours)
            :this(type)
        {
            this.hoursLife = hours;
        }
        public string Type
        {
            get
            { return this.type; }
            set
            {
                if (value != null)
                {
                    this.type = value;
                }
            }
        }
        public float Hours
        {
            get
            { return this.hoursLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery hours can not be negative");
                }
                    this.hoursLife = value;
                
            }
        }
        public override string ToString()
        {
            StringBuilder resultStr = new StringBuilder();
            if (this.Type != null)
            {
                resultStr.AppendLine("battery: " + this.Type);
            }
            if (this.Hours > 0)
            {
                resultStr.AppendLine("hours: " + this.Hours);
            }
            return resultStr.ToString();
        }
    }
}
