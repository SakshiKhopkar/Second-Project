using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Book
    {
        private int Bookid, Bookprice;
        private string Bookname, Authorname;

        public  Book()
        {
            Bookid= 700;
            Bookprice= 150;
            Authorname = "xyz";
            Bookname ="ABC";
        }
        public  Book(int id,int price,string name,string Aname)
        {
            Bookid = id;
            Bookprice = price;
            Authorname = name;
            Bookname = Aname;
        }
        public string PrintBook()
        {
            return $"Book:{Bookid}\n{Bookname}\n{Authorname}\n{Bookprice}";
        }
    }
}
