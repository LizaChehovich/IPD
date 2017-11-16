using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Battery
{
    class BatteryManager
    {
        private const int TimeLen = 10;

        private readonly int _systemTimeout;
        private PowerLineStatus _prevState;
        private bool _init;

        private int _timeOut;
        private PowerLineStatus _state;
        private float _percentage;
        private int _time;
        
        public BatteryManager()
        {
            _init = false;
            _systemTimeout = GetCurrentTimeout();
            UpdateState();
        }

        public int TimeOut => _timeOut;

        public PowerLineStatus State => _state;

        public float Percentage => _percentage;

        public int Time => _time;

        private int GetCurrentTimeout()
        {
            var p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c powercfg /q";
            p.Start();
            var powercfgOut = p.StandardOutput.ReadToEnd();
            var reg = new Regex("VIDEOIDLE.*\\n.*\\n.*\\n.*\\n.*\\n.*\\n.*");
            var videoidle = reg.Match(powercfgOut).Value;
            var batteryIdle = videoidle.Substring(videoidle.Length - 1 - TimeLen).TrimEnd();
            return Convert.ToInt32(batteryIdle, 16) / 60;
        }
        
        public void UpdateState()
        {
            _state = SystemInformation.PowerStatus.PowerLineStatus;
            if (!_init)
            {
                _prevState = _state;
                _timeOut = _systemTimeout;
                _init = true;
            }
            _percentage = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            if (_state == PowerLineStatus.Offline)
            {
                _time = SystemInformation.PowerStatus.BatteryLifeRemaining;
            }
            else
            {
                _time = 0;
                if (_prevState != _state)
                    ResetTimeout();
            }
        }
        
        private void SetTimeout()
        {
            var p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = "/c powercfg /x -monitor-timeout-dc " + _timeOut;
            p.Start();
        }

        public void SetNewTimeout(int timeOut)
        {
            _timeOut = timeOut;
            SetTimeout();
        }

        public void ResetTimeout()
        {
            _timeOut = _systemTimeout;
            SetTimeout();
        }
    }
}