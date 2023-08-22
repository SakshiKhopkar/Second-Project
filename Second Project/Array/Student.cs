using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    public class Student
    {
        public int Id;
        public string Name; 
        public double Per;
        public Student(int Id,string Name,double Per)
        {
            this.Id = Id;
            this.Name = Name;
            this.Per = Per;
        }
    }
    public class RunStudent
    {
        static void Main(string[] args)
        {
            Student[] list = new Student[3]
            {
                new Student(11,"sapna",88.8),
                new Student(12,"shweta",80.8),
                new Student(13,"rahul",78.8),
            };
            foreach (Student S in list )
            {
                Console.WriteLine($"{S.Id} {S.Name} {S.Per}");
            }
        }
    }
}
