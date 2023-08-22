using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Bank
    {
        private int Acno;
        private string Name;
        private double Balance;
        private static double homeloan=44.5;

        public Bank(int no, string name, double balance)
        {
            Acno = no;
            Name = name;
            Balance = balance;

        }

        public static double Gethomeloan()
        {
            return homeloan;
        }
        public void Credit (double creditamt)
        {
               Balance += creditamt;
        }

        public string Debit(double debitamt)
        {
            string msg = "";
            if (Balance >= debitamt)
            {
                Balance = Balance - debitamt;
                msg = "Transaction Done";
            }
            else
            {
                msg = "insufficient Balace";
            }
            return msg;
               
        }
        public string Print()
        {
            return $"AccountNo {Acno}-Username{Name}-Available{Balance}";
        }

            

    }
}
