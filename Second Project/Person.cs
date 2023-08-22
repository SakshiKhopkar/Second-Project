using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Person
    {
        protected string name, address;
        protected long aadhaarno;
        public Person(string name, string address, long aadhaarno)
        {
            this.name = name;
            this.address = address;
            this.aadhaarno = aadhaarno;
        }
        public virtual string Display()
        {
            return $"{name}-{address}-{aadhaarno}";
        }
    }

    public class Patient : Person
    {
        private string bloodgroup,gender;
        private int fees;
        public Patient(string bloodgroup,string gender,int fees, string name, string address, long aadhaarno) : base(name, address, aadhaarno)
        {
            this.bloodgroup = bloodgroup;
            this.gender = gender;
            this.fees = fees;
        }
        public override string Display()
        {
            return $"{bloodgroup}-{gender}-{fees}-{name}-{address}-{aadhaarno}";

        }
    }
}
