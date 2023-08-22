using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{
    //method overriding
    public class Baseclass
    {
        public virtual string Print()
        {
            return "message from base class";
        }
    }
    public class Childclass : Baseclass
    {
        public override string Print()
        {
            return"message from childclass";
        }
    }
}
