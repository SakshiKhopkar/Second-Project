using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Second_Project.Inheretance_Assignment
{
    /*Create an interface with name IPrintable, declare method as Print();
    Implement the interface with Employee, Manager , Student class
    And display the respective details of that class*/


    public interface IPrintable2
    {
        string Print(); 
    }
    public class Student : IPrintable2
    {
        private int rollNo;
        private string name;
        private double math, phy, science,per,sum;

        public Student(int rollNo,string name,double math,double phy,double science)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.math = math;
            this.phy = phy;
            this.science = science;
        }

        public void Calculateper()
        {
            sum = math + phy + science;
            per = sum / 3;
        }

        public string Print()
        {
            return $"Roll no -{rollNo}- Name {name}- percentage {per}";
        }
    }
}
