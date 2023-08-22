using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Account
    {
        private int Accountnumber, Balance,withdraw,deposit;
        private string AccountType;

        public void Accept(int AcNo,int Bal,string AcType,int withdraw,int deposit)
        {
            Accountnumber = AcNo;
            Balance = Bal;
            AccountType = AcType;
            this.withdraw = withdraw;
            this.deposit = deposit;
        }
        public void CalculateWithdraw()
        {
            withdraw = Balance - withdraw;
            if (withdraw <= 0)
            {
                Console.WriteLine(" you don't have suitable balance");
            }
        }
        public void CalculateDeposit()
        {
            deposit =Balance + deposit;
            //Console.WriteLine(deposit);
        }
        public void diaplay()
        {
            Console.WriteLine(Accountnumber);
            Console.WriteLine(Balance );
            Console.WriteLine(AccountType);
            Console.WriteLine(withdraw);
            Console.WriteLine(deposit);
        }
    }
}
