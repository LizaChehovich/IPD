using System;
using System.Collections.Generic;
using System.Management;

namespace DeviceManager
{
    class DeviceManager
    {
        private List<Driver> GetListDrivers(ManagementObject device)
        {
            List<Driver> listDrivers = new List<Driver>();
            foreach (var driver in device.GetRelated("Win32_SystemDriver"))
            {
                listDrivers.Add(new Driver
                {
                    Description = driver.Properties["Description"].Value?.ToString(),
                    SysPath = driver.Properties["PathName"].Value?.ToString()
                });
            }
            return listDrivers;
        }

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
                    ListDrivers = GetListDrivers(device),
                    Path = device.GetPropertyValue("DeviceID")?.ToString(),
                    Status = (Status)Enum.Parse(typeof(Status),device.GetPropertyValue("Status").ToString())
                });
            }
            return listDevices;
        }
    }
}
