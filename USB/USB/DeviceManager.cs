using System.Collections.Generic;
using System.IO;
using System.Linq;
using MediaDevices;
using UsbEject;
using System.Windows.Forms;

namespace USB
{
    class DeviceManager
    {
        private List<Volume> GetVolumes(IEnumerable<MediaDirectoryInfo> root)
        {
            List<Volume> volumes = new List<Volume>();
            foreach (var volume in root)
            {
                DriveInfo driveInfo = new DriveInfo(volume.Name);
                volumes.Add(new Volume(volume.Name, driveInfo.TotalFreeSpace, driveInfo.TotalSize));
            }
            return volumes;
        }

        private List<Volume> GetVolumes(IEnumerable<MediaDirectoryInfo> root, string name)
        {
            List<Volume> volumes = new List<Volume>();
            foreach (var volume in root)
            {
                volumes.Add(new Volume(volume.Name));
            }
            return volumes;
        }

        public List<Device> GetListConnectedDevices()
        {
            List<Device> devices = new List<Device>();
            foreach (var device in MediaDevice.GetDevices())
            {
                device.Connect();
                var root = device.GetRootDirectory().EnumerateDirectories();
                devices.Add(new Device(device.FriendlyName, device.DeviceType,
                            device.DeviceType == DeviceType.Generic ? GetVolumes(root) : GetVolumes(root, device.FriendlyName)));
                device.Disconnect();
            }
            return devices;
        }

        public bool EjectDevice(Device device)
        {
            var nameVolumeDevice = device.Volumes.First().Name;
            var ejectedDevice = new VolumeDeviceClass().SingleOrDefault(v => v.LogicalDrive == nameVolumeDevice);
            ejectedDevice?.Eject(false);
            return new VolumeDeviceClass().SingleOrDefault(v => v.LogicalDrive == nameVolumeDevice) == null ? true : false;
        }
    }
}
