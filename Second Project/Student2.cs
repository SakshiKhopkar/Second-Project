using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Student2
    {
        private int rollNo;
        private string name;
        private double percentage;

        public int RollNo
        {
            set { rollNo=value; }
            get { return rollNo; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
    }

    }