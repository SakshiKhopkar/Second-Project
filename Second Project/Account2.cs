using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    /**6) Create a class Account containing following methods :
insert() to insert account data
display() to display account information
deposit() to deposit amount
withdraw() to withdraw amount
checkbalance() to check balance
e.g.
class Account
    {
        int acc_no;
        String name;
        float amount;
    }**/

    public class Account2
    {
        private int accno;
        private string name;
        private double amount;

       
        public void insert(int accno,string name,double amount)
        {
          this.accno=accno;
            this.name=name;
            this.amount=amount;
        }
        public string DisplayAcc()
        {
            return $"account number is{accno}- Accountant name is{name}-Amount is{amount}";
        }

        public void Deposit(double depotamt)
        {
            amount += depotamt;
        }
        public string Withdraw(double withdrawamt)
        {
            string msg = "";
            if (amount >= withdrawamt)
            {
                amount = amount - withdrawamt;
                msg = "Transaction Done";
            }
            else
            {
                msg = "insufficient Balace";
            }
            return msg;

        }
        public string Cheakbalance() 
        {
            return $"{amount}";
        }

    }
}
