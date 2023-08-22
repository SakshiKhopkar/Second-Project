using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Abstraction_assignment
{
    public abstract class OpenPhonebook
    {
        public string name;
        public long contactno;

        public abstract void Accept(string name, long contactno);
        public abstract string Display();
    }
    public class Ponebook : OpenPhonebook
    {
        public override void Accept(string name, long contactno)
        {
            this.name = name;
            this.contactno = contactno;
        }
        public override string Display()
        {
            return $"{name}-{contactno}";
        }

    }
    public class important
    {
        static void Main(string[] args)
        {
            Ponebook p1 = new Ponebook();
            p1.Accept("swati", 23341566789);
            p1.Display();
            Console.WriteLine(p1.Display());
        }
    }
}

