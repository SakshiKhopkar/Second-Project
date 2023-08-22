using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Movie
    {
        private int mid;
        private string mname;
        private int tprice;
        private int noofticket;
        private string mtype;
        private int want;
        private int totalbill;
        //private int ticketwant;

        public Movie(int mid, string mname, int tprice, int nooftickets)
        {
            this.mid = mid;
            this.mname = mname;
            this.tprice = tprice;
            this.noofticket = nooftickets;
            
        }
        public string Printmember()
        {
            return $"{mid} {mname} {tprice} {noofticket}";
        }
        public void Available()
        {
            Console.WriteLine("Enter the number of tickets");
            want = Convert.ToInt32(Console.ReadLine());
            if (noofticket > want)
            {
                int available = noofticket - want;
                this.TicketCost();
            }
            else
            {
                Console.WriteLine("not sufficient tickets");
            }
        }
        public void TicketCost()
        {
            Console.WriteLine(" 1.silver");
            Console.WriteLine("2.gold");
            Console.WriteLine("3.platinum");
            Console.WriteLine("enter type ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    mtype = "silver";
                    tprice = 100;
                    break;
                case 2:
                    mtype = "gold";
                    tprice = 200;
                    break;
                case 3:
                    mtype = "platinum";
                    tprice = 300;
                    break;
            }
            totalbill = want * tprice;
        }

           public string print()
            {
                Console.WriteLine("details of booking");
                return $"your movie name is {mname}-your movie id is {mid}-ticket you want{want}- your total bill{totalbill}";
            }
        
    }
}
