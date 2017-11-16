using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManager
{
    class Driver
    {
        private string _description;
        private string _sysPath;

        public Driver(string description, string sysPath)
        {
            _description = description;
            _sysPath = sysPath;
        }

        public string Description => _description;

        public string SysPath => _sysPath;
    }
}
