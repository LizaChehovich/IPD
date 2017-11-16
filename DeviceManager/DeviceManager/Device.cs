namespace DeviceManager
{
    class Device
    {
        private string _name;
        private string _guid;
        private string _hardwareID;
        private string _manufacturer;
        private Driver _driver;
        private string _path;
        private Status _status;

        public Device(string name, string guid, string hardwareID, string manufacturer, 
            Driver driver, string path, Status status)
        {
            _name = name;
            _guid = guid;
            _hardwareID = hardwareID;
            _manufacturer = manufacturer;
            _driver = driver;
            _path = path;
            _status = status;
        }

        public string Name => _name;

        public string GUID => _guid;

        public string HardwareID => _hardwareID;

        public string Manufacturer => _manufacturer;

        public Driver Driver => _driver;

        public string Path => _path;

        public Status Status => _status;
    }
}
