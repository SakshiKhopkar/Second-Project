using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.Inheretance_Assignment
{
    public class Laptop
    {
        private int NOOfUSBPort;
        private double processorSpeed;
        
        public int noOfUSBPort
        {
            get { return NOOfUSBPort; }
            set { NOOfUSBPort = value; }
        }

        public double Processor
        {
            get { return processorSpeed; }
            set { processorSpeed = value; }
        }
    }
}
