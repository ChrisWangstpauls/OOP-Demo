using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Demo
{
    //INHERITANCE DEMO 
    public abstract class Product
    {
        public string name;
        public int price;
        public int quantity;

        //Constructor
        public Product()
        {
            name = null;
            price = 0;
            quantity = 0;
        }

        public virtual string GetName()
        {
            return name;
        }

        public virtual int GetPrice()
        {
            return price;
        }

        public virtual int GetQuantity()
        {
            return quantity;
        }

        public virtual bool IsAvailable()
        {
            if (quantity > 0)
                return true;
           else return false;
        }
    }
}
