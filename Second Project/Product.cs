using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Product
    {
        private int Productid;
        private string Productname;
        private double Price;

        public Product(int id,string name , double price)
        {
            Productid = id;
            Productname = name;
            Price = price;
        }
        public void Discount(double discountper)
        {
            Price = Price - ( Price * (discountper / 100)); 
        }
         
        public string Print()
        {
            return $"product id={Productid}\n Productname={Productname}\n{Price}";
           
        }
    }
}
