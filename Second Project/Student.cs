using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Student
    {
        private int rollNo;
        private string Name, branch;
        private double math, phy, science, percentage, total;

       public Student()
        {
            rollNo = 0;
            Name =" ";
            branch = "";
            math = 0.0;
            phy= 0.0; science =0.0;

        }
        public Student(string bran,int math,int phy,int science)
        {
            branch = bran;
            this.math = math;
            this.phy = phy;
            this.science = science;
        }
        /*public void Displaydata(int roll, string name)
        {
            rollNo = roll;
            Name = name;
            Console.WriteLine(roll);
            Console.WriteLine(name);

        }*/
        public void Calculatepercentage()
        {
            total = math + phy + science;
            percentage = total / 3;
        }
        public void CalculateGrade()
        {
            if (percentage > 90)
            {
                Console.WriteLine("A grade");
            }
            else if(percentage > 50) 
            {
                Console.WriteLine("B grade");

            }
            else
            {
                Console.WriteLine("C grade");
            }

        }
        public string PrintStudent()
        {
            return $"Student:{rollNo}-{percentage}-{Name}-{branch}";
        }
    }
}
