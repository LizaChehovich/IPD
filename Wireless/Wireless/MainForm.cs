using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wireless
{
    public partial class MainForm : Form
    {
        private readonly WifiManager _wifiManager = new WifiManager();

        private List<WifiInfo> _wifiInfoList = new List<WifiInfo>();

        public MainForm()
        {
            InitializeComponent();
            UpdateWifiInfo(null, null);
            tmUpdate.Tick += UpdateWifiInfo;
            tmUpdate.Interval = 5000;
            tmUpdate.Start();
        }

        private void UpdateWifiInfo(object sender, EventArgs e)
        {
            _wifiInfoList = _wifiManager.GetWifiInfoList();
            listBox1.Items.Clear();
            foreach (var wifiInfo in _wifiInfoList)
            {
                listBox1.Items.Add(String.Join("|",
                    new string[]
                    {
                        wifiInfo.Name, wifiInfo.SignalQuality.ToString(), wifiInfo.IsConnected.ToString(),
                        wifiInfo.AuthType, wifiInfo.IsSecure.ToString()
                    }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _wifiManager.Connect(_wifiInfoList.First(), "b2sthebest");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _wifiManager.Disconnect();
        }
    }
}
