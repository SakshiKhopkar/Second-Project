using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Car
    {
        private string companyname, carmodel;
        private int cost;

        public Car(string modelname, int cost, string companyname = "hundai")
        {
            carmodel = modelname;
            this.cost = cost;
            this.companyname = companyname;
        }
        public void Accept(string modelname, string companyname = "Hundai")
        {
            carmodel = modelname;
            this.companyname = companyname;
        }

        public string Print()
        {
            return $"{carmodel}-{cost}-{companyname}";
        }

    }
    public class important
    {
        static void Main(string[] args)
        {
        Car c1 = new Car("i8", 900000);
        Car c2 = new Car("i10", 800000, "Tata");
        Console.WriteLine(c1.Print());
        Console.WriteLine(c2.Print());
        }
    
            
    
    }

}
