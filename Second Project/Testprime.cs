using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public  class Testprime
    {
        public bool isprimecheak(int n)
        {
            bool isprime = true;
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            return isprime;
        }
    }
}
