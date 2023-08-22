using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public class Animal
    {
        protected string type;
        protected string animalname;

        public Animal(string type, string animalname)
        {

            this.type = type;
            this.animalname = animalname;
        }

        public virtual string Display()
        {
            return $"{type}-{animalname}";
        }

    }
    public class Dog : Animal
    {
        private string color, bred, dogname;

        public Dog(string color, string bred, string dogname, string type, string animalname) : base(type, animalname)
        {
            this.color = color;
            this.bred = bred;
            this.dogname = dogname;
        }
        public override string Display()
        {
          return$"Dog={color}-{bred}-{dogname}-{type}-{animalname}";
        }

    }
    public class Cat : Animal
    {
        private string gender, Catname;
        public Cat(string gender, string catname,string type , string animalname):base(type, animalname)
        {
            this.gender = gender;
            Catname = catname;
        }
        public override string Display()
        {
            return $"{gender}-{Catname}-{type}-{animalname}";
        }
    }


}
