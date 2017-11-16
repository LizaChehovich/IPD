using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace USB
{
    public partial class MainForm : Form
    {
        private const long BytesInMegabyte = 1024 * 1024;
        private const int WmDevicechange = 0x0219;
        private DeviceManager _deviceManager;
        private List<Device> _listDevice;

        public MainForm()
        {
            InitializeComponent();
            _deviceManager = new DeviceManager();
            UpdateDeviceTable();
        }

        private void btEject_Click(object sender, EventArgs e)
        {
            if (dGVDevices.CurrentRow?.Index >= 0)
            {
                Device device = _listDevice[dGVDevices.CurrentRow.Index];
                if (device.DeviceType == MediaDevices.DeviceType.Generic)
                {
                    if(!_deviceManager.EjectDevice(device))
                        MessageBox.Show(@"Это устройство занято", @"Ошибка");
                }
                else
                {
                    MessageBox.Show(@"Это устройство нельзя извлечь", @"Ошибка");
                }
            }
        }

        private void UpdateDeviceTable()
        {
            if (!InvokeRequired)
            {
                dGVDevices.Rows.Clear();
                _listDevice = _deviceManager.GetListConnectedDevices();
                FillDeviceTable();
            }
            else
            {
                Invoke(new Action(UpdateDeviceTable));
            }
        }

        private void FillDeviceTable()
        {
            foreach(var device in _listDevice)
            {
                dGVDevices.Rows.Add(GetDataGridViewRow(device));
            }
        }

        private DataGridViewRow GetDataGridViewRow(Device device)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dGVDevices);
            dataGridViewRow.Cells[0].Value = device.Name;
            dataGridViewRow.Cells[1].Value = device.DeviceType;
            if(device.DeviceType == MediaDevices.DeviceType.Generic)
            {
                dataGridViewRow.Cells[2].Value = device.Volumes[0].TotalSpace / BytesInMegabyte;
                dataGridViewRow.Cells[3].Value = device.Volumes[0].FreeSpace / BytesInMegabyte;
                dataGridViewRow.Cells[4].Value = device.Volumes[0].UsedSpace / BytesInMegabyte;
                dataGridViewRow.Cells[5].Value = device.Volumes[0].Name;
            }
            else
            {
                foreach(var volume in device.Volumes)
                {
                    dataGridViewRow.Cells[5].Value += volume.Name + ", ";
                }
            }
            return dataGridViewRow;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WmDevicechange)
            {
                UpdateDeviceTable();
            }
            base.WndProc(ref m);
        }
    }
}
