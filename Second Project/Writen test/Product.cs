using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Writen_test
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            set{ price= value;}
            get { return price; }
        }
        public void Discount(double discountpri)
        {
            price = price - (price * (discountpri / 100));
        }
        public string Display()
        {
            return $"{id}-{name}-{price}";
        }
    }
}
