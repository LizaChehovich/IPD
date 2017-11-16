using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery
{
    public partial class Battery : Form
    {

        private BatteryManager _manager;

        public Battery()
        {
            InitializeComponent();
        }

        private void Battery_Load(object sender, EventArgs e)
        {
            _manager = new BatteryManager();
            UpdateInfo(null, null);
            tmUpdate.Tick += UpdateInfo;
            tmUpdate.Interval = 1000;
            tmUpdate.Start();
        }

        private void Battery_FormClosing(object sender, FormClosingEventArgs e)
        {
            _manager.ResetTimeout();
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            _manager.UpdateState();
            lbStateChange.Text = StateToString(_manager.State);
            lbPercentageChange.Text = _manager.Percentage + @"%";
            if (_manager.State == PowerLineStatus.Online)
            {
                gbTimeOut.Visible = false;
                lbTime.Visible = false;
                lbTimeChange.Visible = false;
            }
            else
            {
                gbTimeOut.Visible = true;
                lbTime.Visible = true;
                lbTimeChange.Visible = true;
                lbTimeChange.Text = TimeToString(_manager.Time);
                cbTimeOut.Text = _manager.TimeOut.ToString();
            }
        }

        private String StateToString(PowerLineStatus _status)
        {
            String status = String.Empty;
            if (_status == PowerLineStatus.Offline)
                status = @"Разряжается";
            if (_status == PowerLineStatus.Online)
                status = @"Заряжается";
            return status;
        }

        private String TimeToString(int _time)
        {
            String time = String.Empty;
            if(_time==-1)
            {
                time = @"Идет вычисление...";
            }
            else
            {
                time = new TimeSpan(0, 0, _time).ToString("g");
            }
            return time;
        }

        private void cbTimeOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newTimeOut = Convert.ToInt32(cbTimeOut.SelectedItem);
            if (newTimeOut != _manager.TimeOut)
            {
                _manager.SetNewTimeout(Convert.ToInt32(cbTimeOut.SelectedItem));
            }
        }
    }
}
