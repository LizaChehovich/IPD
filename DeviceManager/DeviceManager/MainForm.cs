using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceManager
{
    public partial class MainForm : Form
    {
        private DeviceManager _deviceManager;
        private List<Device> _listDevices;

        public MainForm()
        {
            InitializeComponent();
            _deviceManager = new DeviceManager();
            UpdateListDevices();
        }

        private void UpdateListDevices()
        {
            lBDevices.Items.Clear();
            _listDevices = _deviceManager.GetListDevices();
            foreach (var device in _listDevices)
            {
                lBDevices.Items.Add(device.Name);
            }
        }

        private void lBDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBDevices.SelectedIndex != -1)
            {
                FillDeviceInfo(_listDevices[lBDevices.SelectedIndex]);
            }
        }

        private void FillDeviceInfo(Device device)
        {
            tBGUID.Text = device.GUID;
            if (device.HardwareIDs != null)
            {
                foreach (var hardwareID in device.HardwareIDs)
                {
                    tBHardwareIDs.Text += hardwareID + '\n';
                }
            }
            tBManufacturer.Text = device.Manufacturer;
            tBPath.Text = device.Path;
            tBStatus.Text = device.Status.ToString();
        }
    }
}
