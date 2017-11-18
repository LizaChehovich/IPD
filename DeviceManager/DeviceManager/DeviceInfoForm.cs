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
    public partial class DeviceInfoForm : Form
    {
        private readonly Device _device;

        public DeviceInfoForm(Device device)
        {
            InitializeComponent();
            _device = device;
            InitializePages();
        }

        private void InitializePages()
        {
            InitializeCommonPade();
            InitializeDriversPage();
        }

        private void InitializeCommonPade()
        {
            tBName.Text = _device.Name;
            tBClass.Text = _device.Class;
            tBGUID.Text = _device.GUID;
            tbHIDs.Text = String.Join("\n", _device.HardwareIDs);
            tBManufacturer.Text = _device.Manufacturer;
            tBPath.Text = _device.Path;
            tBState.Text = _device.Status == Status.OK ? "Устройство работает нормально" : "Устройство отключено";
        }

        private void InitializeDriversPage()
        {
            foreach (var driver in _device.ListDrivers)
            {
                lBDrivers.Items.Add(driver.Description);
            }
        }

        private void lBDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBDrivers.SelectedIndex != -1)
            {
                tBDriverPath.Text = _device.ListDrivers[lBDrivers.SelectedIndex].SysPath;
            }
        }
    }
}
