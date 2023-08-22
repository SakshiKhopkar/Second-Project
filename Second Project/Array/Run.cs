using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Array
{
    internal class Run
    {
        static void Main(string[] args)
        {
            Employee[] list = new Employee[3]
            {
                new Employee{Id=1,Name="Swapnil",Salary=20000},
                new Employee{Id=2,Name="Sagar",Salary=40000},
                new Employee{Id=3,Name="Gita",Salary=60000},

            };
            foreach (Employee p in list)
            {
                Console.WriteLine( $"{p.Id} {p.Name} {p.Salary}");
            }
            Console.WriteLine("******************************");
            Book[] list2 = new Book[3]
                {
                new Book{Id=1,Name="Agnipankh",Authar="A.P.J.abdulkalam",Price=300},
                new Book{Id=2,Name="Gagnbharari",Authar="Devendra bhujbal",Price=400},
                new Book{Id=3,Name="Batatychi chawl",Authar="Pul deshpande",Price=500},

                };
            foreach(Book b in list2) 
            { 
                Console.WriteLine($"{b.Id} {b.Name} {b.Authar} {b.Price}"); 
            }
        }
    }
}
