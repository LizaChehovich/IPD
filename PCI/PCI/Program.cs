using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.IO;

namespace PCI
{
    class Program
    {
        static void Main(string[] args)
        {
            printDevices(setNameDevices(getPCIDevices()));
        }

        private static List<Device> getPCIDevices()
        {
            ManagementObjectSearcher devices = new ManagementObjectSearcher("root\\CIMV2",
                "SELECT * FROM Win32_PnPEntity");
            Parser parser = new Parser();
            List<Device> deviceList = new List<Device>();
            foreach (ManagementObject deviceObj in devices.Get())
            {
                if (parser.CheckPCI(deviceObj))
                {
                    deviceList.Add(new Device(parser.GetVendorId(deviceObj), parser.GetDeviceId(deviceObj)));
                }
            }
            return deviceList;
        }

        private static List<Device> setNameDevices(List<Device> deviceList)
        {
            Parser parser = new Parser();
            string[] file = File.ReadAllLines(@"../../pci.ids.txt", Encoding.Default);
            foreach (Device device in deviceList)
            {
                parser.InitRegex(device.VendorId, device.DeviceId);
                for (int i = 0; i < file.Count(); i++)
                {
                    var venName = parser.CheckStringIsVendor(file[i]);
                    if (venName != "")
                    {
                        device.VendorName = venName;
                        for (int j = i + 1; j < file.Count(); j++)
                        {
                            var devName = parser.CheckStringIsDevice(file[j]);
                            if (devName != "")
                            {
                                device.DeviceName = devName;
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            return deviceList;
        }

        private static void printDevices(List<Device> deviceList)
        {
            foreach (Device device in deviceList)
            {
                Console.WriteLine("VendorID:{0}", device.VendorId);
                Console.WriteLine("DeviceID:{0}", device.DeviceId);
                Console.WriteLine("VendorName:{0}", device.VendorName);
                Console.WriteLine("DeviceName:{0}", device.DeviceName);
                Console.WriteLine("#################");
            }
        }
    }
}
