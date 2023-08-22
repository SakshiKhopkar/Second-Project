using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Prime1to10
    {
        //private int n;
        public bool isprimecheak(int n)
        {
            bool isprime = true;
            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }
    }
}
