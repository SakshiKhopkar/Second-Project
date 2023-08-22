using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Surprise_test
{
    public class Constructor_overload
    {
        private int id;
        private string sname;
        private double sper;

        public Constructor_overload()
        {
              int id = 0;
            string sname = "";
            double sper = 0.0;
        }

        public Constructor_overload(int id,string name,double sper)
        {
          this.id = id;
          this.sname = name;
          this.sper = sper;
        }
        public string Display()
        {
            return $"{id}-{sname}-{sper}";
        }
    }
}
