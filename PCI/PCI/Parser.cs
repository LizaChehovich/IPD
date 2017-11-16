using System.Management;
using System.Text.RegularExpressions;

namespace PCI
{
    class Parser
    {
        private Regex _deviceIdExp;
        private Regex _vendorIdExp;
        private Regex _deviceNameExp;
        private Regex _vendorNameExp;

        public Parser()
        {
            _deviceIdExp = new Regex("(?<=DEV_)(.{4})");
            _vendorIdExp = new Regex("(?<=VEN_)(.{4})");
        }

        public bool CheckPCI(ManagementObject device)
        {
            return device["DeviceID"].ToString().Contains("PCI");
        }

        public string GetVendorId(ManagementObject device)
        {
            return _vendorIdExp.Match(device["DeviceID"].ToString()).ToString().ToLower();
        }

        public string GetDeviceId(ManagementObject device)
        {
            return _deviceIdExp.Match(device["DeviceID"].ToString()).ToString().ToLower();
        }

        public void InitRegex(string vendorId, string deviceId)
        {
            _vendorNameExp = new Regex("(?<=^" + vendorId + "  )(.+)");
            _deviceNameExp = new Regex("(?<=^\t" + deviceId + "  )(.+)");
        }

        public string CheckStringIsVendor(string str)
        {
            return _vendorNameExp.Match(str).ToString();
        }

        public string CheckStringIsDevice(string str)
        {
            return _deviceNameExp.Match(str).ToString();
        }
    }
}
