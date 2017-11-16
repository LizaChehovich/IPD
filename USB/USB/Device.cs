using System.Collections.Generic;
using MediaDevices;

namespace USB
{
    class Device
    {
        private string _name;
        private DeviceType _deviceType;
        private List<Volume> _volumes;

        public Device(string name, DeviceType deviceType, List<Volume> volumes)
        {
            _name = name;
            _deviceType = deviceType;
            _volumes = volumes;
        }

        public string Name => _name;

        public DeviceType DeviceType => _deviceType;

        public List<Volume> Volumes => _volumes;
    }
}
