using System.Collections.Generic;

namespace DeviceManager
{
    public class Device
    {
        private string _name;

        private string _class;

        public string Name
        {
            get => _name;
            set => _name = string.IsNullOrEmpty(value) ? "Неизвестное устройство" : value;
        }

        public string GUID { get; set; }
        public string[] HardwareIDs { get; set; }
        public string Manufacturer { get; set; }
        public List<Driver> ListDrivers { get; set; }
        public string Path { get; set; }
        public Status Status { get; set; }

        public string Class
        {
            get => _class;
            set => _class = string.IsNullOrEmpty(value) ? "Другие устройства" : value;
        }
    }
}
