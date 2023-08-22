using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project.method_Assignment
{//code where one child can access 2 interface
    public interface IWiFiconnectable
    {
        void ConnectWifi();
    }
    public interface IbluetoothConnectable
    {
        void ConnectBluetooth();
    }
    public class Digitaldevice : IWiFiconnectable, IbluetoothConnectable
    {
        public void ConnectWifi()
        {
            Console.WriteLine("connected to WiFi");
        }
        public void ConnectBluetooth()
        {
            Console.WriteLine("connected to Bluetooth");
        }
    } 
}
