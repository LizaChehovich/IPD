namespace DeviceManager
{
    class Device
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = string.IsNullOrEmpty(value) ? "Неизвестное устройство" : value;
        }

        public string GUID { get; set; }
        public string[] HardwareIDs { get; set; }
        public string Manufacturer { get; set; }
        public Driver Driver { get; set; }
        public string Path { get; set; }
        public Status Status { get; set; }
    }
}
