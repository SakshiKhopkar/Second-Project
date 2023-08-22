using Second_Project.Writen_test;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** Date dateobj1 = new Date();
             dateobj1.AcceptDate(4, "Aug", 2023);
             string res = dateobj1.PrintDate();
             Console.WriteLine(res);
             Console.WriteLine();


             Student objstudent= new Student();
             Student objstudent1= new Student(66, "sakshi", "Science", 77, 80, 60);
             objstudent.Calculatepercentage();
             objstudent1.Calculatepercentage();
             string detail = objstudent.PrintStudent();
             string detail2 = objstudent1.PrintStudent();
             Console.WriteLine(detail);
             Console.WriteLine(detail2);
             objstudent.CalculateGrade();
             objstudent1.CalculateGrade();
             Console.WriteLine();

             Employ objemployee = new Employ();
             Employ objemployee2 = new Employ( "sakshi", "Software", 15000);
             Employ ob3 = new Employ("sanjog","IT",45000);
             objemployee.CalculateSalary();
             objemployee2.CalculateSalary();
             Console.WriteLine(objemployee.PrintEmploy());
             Console.WriteLine(objemployee2.PrintEmploy());
             Console.WriteLine(ob3.PrintEmploy());
             Console.WriteLine("employee count is"+Employ.Getemploycount());
             Console.WriteLine();

             Book objbook = new Book();
             Book objbook2= new Book(415303, 200, "Aganipank", "A P J Abdulkalam");
             string Bookdata = objbook.PrintBook();
             string Bookdata2 = objbook2.PrintBook();
             Console.WriteLine(Bookdata);
             Console.WriteLine(Bookdata2);
             Console.WriteLine();

             Account objAccount=new Account();
             objAccount.Accept(192000524, 70000, "saving", 550, 550);
             objAccount.CalculateWithdraw();
             objAccount.CalculateDeposit();
             objAccount.diaplay();

             Bank obj1 = new Bank(2233, "sapana", 150000);
             Console.WriteLine(obj1.Print());
             obj1.Credit(5000);
             Console.WriteLine(obj1.Print());
             string msg= obj1.Debit(66000);
             Console.WriteLine(msg);
             Console.WriteLine(obj1.Print());
             Console.WriteLine();

             Product B = new Product(4555, "shoes", 500);
             Console.WriteLine(B.Print());
             B.Discount(10);
             Console.WriteLine("Price after Discount");
             Console.WriteLine(B.Print());**/


            /**Student2 obj1 = new Student2();
            obj1.RollNo = 12;
            obj1.Name = "shweta";
            obj1.Percentage = 99.7;
            Console.WriteLine($"{obj1.RollNo} {obj1.Name} {obj1.Percentage}");
            Student2 obj2 = new Student2() { RollNo = 55, Name = "samiksha", Percentage = 89.9 };
            Console.WriteLine($"{obj2.RollNo} {obj2.Name} {obj2.Percentage}"); 
            Console.WriteLine();

            Product2 p1 = new Product2();
            p1.Code = 11;
            p1.Name = "washing machine";
            p1.Price = 30000;
            Console.WriteLine($"{p1.Code} {p1.Name} {p1.Price}");
            Product2 p2 = new Product2() { Code=12,Name="Tv",Price=20000};
            Console.WriteLine($"{p2.Code} {p2.Name} {p2.Price}");**/

            /** Movie m1=new Movie(200,"barbie",200,20);
             Console.WriteLine( m1.Printmember());
             m1.Available();
             Console.WriteLine( m1.print());**/

            /**Prime1to10 t = new Prime1to10();
           // bool cheak = t.isprimecheak();
            for (int i= 1; i<=10; i++) 
            {
                bool cheak = t.isprimecheak(i);
                if(cheak)
                {
                    Console.WriteLine(i);
                }

            }
          // bool cheak= t.isprimecheak();

            Calculation c1 = new Calculation();
            Console.WriteLine( c1.Addition(33, 55));
            Console.WriteLine( c1.Addition(33.9, 66.88));
            Console.WriteLine( c1.Addition(55, 67, 80));
            Console.WriteLine( c1.Addition(55, 8.9));**/

            /**Rupee r1= new Rupee();
            Console.WriteLine("enter your rupees");
            double num= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("doller value is");
            r1.RtoD(num) ;
            Console.WriteLine();**/

            /**Account2 a1= new Account2();
            a1.insert(123456,"sudha",100000);
            Console.WriteLine( a1.DisplayAcc());
            Console.WriteLine("enter the deposit acount");
            double amt= Convert.ToDouble(Console.ReadLine());
            a1.Deposit(amt);
            Console.WriteLine("enter the value want to withdraw");
            double num= Convert.ToDouble(Console.ReadLine());
            string msg = a1.Withdraw(num);
            Console.WriteLine(msg);
            Console.WriteLine( "your balance is" );
            Console.WriteLine( a1.Cheakbalance());**/

            /*   Student objstudent = new Student("science",88,99,90);
               Student objstudent1 = new Student("Science", 77, 80, 60);
               objstudent1.Displaydata(55, "sanghavi");
               objstudent.Displaydata(88, "samiksha");*/

            /* objstudent.Calculatepercentage();
             objstudent1.Calculatepercentage();
             string detail = objstudent.PrintStudent();
             string detail2 = objstudent1.PrintStudent();
             Console.WriteLine(detail);
             Console.WriteLine(detail2);
             objstudent.CalculateGrade();
             objstudent1.CalculateGrade();
             Console.WriteLine();*/


            /*Car c1 = new Car("i8", 900000);
            Car c2 = new Car("i10", 800000, "Tata");
            Console.WriteLine(c1.Print());
            Console.WriteLine(c2.Print());*/

            /*Manager m1 = new Manager(2000, "nilesh", 55000);
            m1.Print();
            Console.WriteLine(m1.Print());

            Patient p1 = new Patient("AB+", "samiksha", "pune", 123456);
           
            Console.WriteLine(p1.Display());*/
            /*
                        Employee2 e1 = new Manager(2000, "samidha", 55000);
                        e1.CalculateSalary();
                        Console.WriteLine(e1.Print());*/

            /* Person p1 = new Person("sushat", "pune", 123458906);
             p1.Display();
             Console.WriteLine(p1.Display());
             Person p2 = new Patient("A+", "female", 88800, "swati", "sangli", 66743289);
             Console.WriteLine(p2.Display());*/


            /*Employee e1 = new Saleemployee(4000, 78907, "sushant", 80000);
            e1.CalculateSalary();
            Console.WriteLine(e1.Print());*/

            /*Reactangle r = new Reactangle(44, 33);
            Console.WriteLine(r.Display());
            Console.WriteLine(r.Draw("reactangle"));
            r.Area();
            Console.WriteLine(r.Print());
            Circle c = new Circle(5.5);
            Console.WriteLine(c.Display());
            Console.WriteLine(c.Draw("circle"));
            c.Area();
            Console.WriteLine(c.Print());*/

            /*User user1 = new User();
            Console.WriteLine( user1.print());*/

           /* ICustomer c1 = new Transaction();
            Console.WriteLine(c1.Display());
            IOrder c2 = new Transaction();
            Console.WriteLine(c2.Display());*/

           /* Calc c1 = new Calc();
            Console.WriteLine( c1.ADD(44, 66));
            Console.WriteLine(c1.ADD(66.9,88.7));
            Console.WriteLine(c1.sqr(5));*/
               
                

            
        }
    }
}
