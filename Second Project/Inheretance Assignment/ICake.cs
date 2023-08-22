using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public interface ICake
    {
        string Bake();
    }
    public class Strawberry : ICake
    {
        public string Bake()
        {
            return$"cake is Straberry cake";
        }
    }
    
    public class BlackForest : ICake
    {
        public string Bake()
        {
            return $"cake is Blackforest";
        }
    }
}
