using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wireless
{
    public partial class MainForm : Form
    {
        private readonly WifiManager _wifiManager = new WifiManager();
        private List<WifiInfo> _wifiInfoList = new List<WifiInfo>();
        private WifiInfo _selectedWifiInfo;
        private const int PercentInBars = 20;
        private bool _isUpdate;

        public MainForm()
        {
            _isUpdate = false;
            InitializeComponent();
            UpdateWifiInformation(null,null);
            tmUpdate.Interval = 2000;
            tmUpdate.Tick += UpdateWifiInformation;
            tmUpdate.Start();
        }

        private void btPing_Click(object sender, EventArgs e)
        {
            tbxResult.Text = _wifiManager.Ping(tbxAddress.Text);
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            _wifiManager.Disconnect();
        }

        private void btConnected_Click(object sender, EventArgs e)
        {
            _wifiManager.Connect(_wifiInfoList[lbxWifi.SelectedIndex],
                _wifiInfoList[lbxWifi.SelectedIndex].IsSecure ? tbPassword.Text : string.Empty);
        }

        private void lbxWifi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWifi.SelectedIndex == -1) return;
            gbxWifiInfo.Visible = true;
            ShowWifiInfo(_wifiInfoList[lbxWifi.SelectedIndex]);
            if(!_isUpdate)
                tbPassword.Text = string.Empty;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            btConnected.Enabled = tbPassword.Text.Length > 0;
        }

        private void UpdateWifiInformation(object sender, EventArgs e)
        {
            if (_isUpdate) return;
            _isUpdate = true;
            _wifiInfoList = _wifiManager.GetWifiInfoList();
            ClearWifiInfo();
            ShowWifiInfoList();
            _selectedWifiInfo = null;
            _isUpdate = false;
        }

        private void ClearWifiInfo()
        {
            if (lbxWifi.SelectedIndex != -1)
            {
                _selectedWifiInfo = _wifiInfoList[lbxWifi.SelectedIndex];
                gbxWifiInfo.Visible = true;
            }
            else
            {
                gbxWifiInfo.Visible = false;
            }
            lbxWifi.Items.Clear();
        }

        private void ShowWifiInfoList()
        {
            var isConnected = false;
            foreach (var wifiInfo in _wifiInfoList)
            {
                lbxWifi.Items.Add(wifiInfo.Name);
                if (_selectedWifiInfo != null && _selectedWifiInfo.Name.Equals(wifiInfo.Name))
                {
                    lbxWifi.SelectedIndex = lbxWifi.Items.Count - 1;
                    ShowWifiInfo(wifiInfo);
                }
                if (!wifiInfo.IsConnected) continue;
                ShowCurrentConnectionInfo(wifiInfo);
                isConnected = true;
            }
            if (!isConnected)
            {
                ShowCurrentConnectionInfo(null);
            }
        }

        private void ShowCurrentConnectionInfo(WifiInfo wifiInfo)
        {
            if (wifiInfo == null)
            {
                gbxCurrentWifiInfo.Visible = false;
            }
            else
            {
                gbxCurrentWifiInfo.Visible = true;
                tbxConnectedName.Text = wifiInfo.Name;
                pbxConnectedSignalQuality.Image = GetImageWifiBar(wifiInfo.SignalQuality);
                tbxConnectedSignalQuality.Text = wifiInfo.SignalQuality.ToString() + @"%";
                tbxConnectedAuthType.Text = wifiInfo.AuthType;
                tbxConnectedMacAddress.Text = string.Join("\n", wifiInfo.MacAddressesList.ToArray());
                tbxConnectedIsSecure.Text = wifiInfo.IsSecure ? "Пароль" : "Нет";
            }
        }

        private void ShowWifiInfo(WifiInfo wifiInfo)
        {
            tbxName.Text = wifiInfo.Name;
            pbxSignalQuality.Image = GetImageWifiBar(wifiInfo.SignalQuality);
            tbxSignalQuality.Text = wifiInfo.SignalQuality.ToString() + @"%";
            tbxAuthType.Text = wifiInfo.AuthType;
            tbxMacAddress.Text = string.Join("\n", wifiInfo.MacAddressesList.ToArray());
            tbxIsSecure.Text = wifiInfo.IsSecure ? "Пароль" : "Нет";
            if (wifiInfo.IsSecure)
            {
                if (tbPassword.Text.Length == 0)
                    btConnected.Enabled = false;
            }
            else
            {
                lbPassword.Visible = false;
                tbPassword.Visible = false;
                btConnected.Enabled = true;
            }
        }

        private Image GetImageWifiBar(int signalQuality)
        {
            return imageList.Images[signalQuality / PercentInBars];
        }
    }
}
