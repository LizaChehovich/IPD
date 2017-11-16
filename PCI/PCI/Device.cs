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

        public string VendorId => _vendorId;

        public string DeviceId => _deviceId;

        public string VendorName
        {
            get { return _vendorName; }
            set { _vendorName = value; }
        }

        public string DeviceName
        {
            get { return _deviceName; }
            set { _deviceName = value; }
        }
    }
}
