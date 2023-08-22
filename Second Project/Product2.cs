using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    //Create Product class with code, name & Price.Assign value using property
   //Use both property & object initializer syntax, & display the product details


    public class Product2
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
