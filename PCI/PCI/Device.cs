namespace PCI
{
    class Device
    {
        private string _vendorId;
        private string _deviceId;
        private string _vendorName;
        private string _deviceName;

        public Device(string vendorId, string deviceId)
        {
            _vendorId = vendorId;
            _deviceId = deviceId;
        }

        public void SetVendorName(string vendorName)
        {
            _vendorName = vendorName;
        }

        public void SetDeviceName(string deviceName)
        {
            _deviceName = deviceName;
        }

        public string VendorId => _vendorId;

        public string DeviceId => _deviceId;

        public string VendorName => _vendorName;

        public string DeviceName => _deviceName;
    }
}
