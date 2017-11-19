using System.Collections.Generic;

namespace Wireless
{
    class WifiInfo
    {
        public string Name { get; set; }
        public List<string> MacAddressesList { get; set; }
        public string AuthType { get; set; }
        public int SignalQuality { get; set; }
        public bool IsConnected { get; set; }
        public bool IsSecure { get; set; }
    }
}
