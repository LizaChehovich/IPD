using System;
using System.Collections.Generic;
using System.Management;

namespace DeviceManager
{
    class DeviceManager
    {
        public List<Device> GetListDevices()
        {
            var listDevices = new List<Device>();
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PNPEntity");
            foreach (ManagementObject device in searcher.Get())
            {
                listDevices.Add(new Device
                {
                    Name = device.GetPropertyValue("Name")?.ToString(),
                    GUID = device.GetPropertyValue("ClassGuid")?.ToString(),
                    HardwareIDs = (string[] )device.GetPropertyValue("HardwareID"),
                    Manufacturer = device.GetPropertyValue("Manufacturer")?.ToString(),
                    Path = device.GetPropertyValue("DeviceID")?.ToString(),
                    Status = (Status)Enum.Parse(typeof(Status),device.GetPropertyValue("Status").ToString())
                });
            }
            return listDevices;
        }
    }
}
