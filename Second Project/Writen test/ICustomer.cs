using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Writen_test
{
    public interface ICustomer
    {
        string Display();
       
    }
    public interface IOrder
    {
        string Display();
    }
    public class Transaction : ICustomer, IOrder
    {
        string ICustomer.Display()
        {
            return $"Customer details";
        }
        string IOrder.Display()
        {
            return $"Order details";
        }
    }
    public class  TransactionRun
    {
        static void Main(string[] args)
        {
            ICustomer s1=new Transaction();
            Console.WriteLine( s1.Display());
            IOrder s2=new Transaction();
            Console.WriteLine(s2.Display());
        }
    }
}
