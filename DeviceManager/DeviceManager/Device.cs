namespace DeviceManager
{
    class Device
    {
        public string Name { get; set; }
        public string GUID { get; set; }
        public string HardwareID { get; set; }
        public string Manufacturer { get; set; }
        public Driver Driver { get; set; }
        public string Path { get; set; }
        public Status Status { get; set; }
    }
}
