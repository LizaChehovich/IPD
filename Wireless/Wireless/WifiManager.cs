using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;
using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;

namespace Wireless
{
    class WifiManager
    {
        private readonly Wifi _wifi = new Wifi();

        private readonly WlanClient _wlanClient = new WlanClient();

        private string Dot11SsidToString(Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID,0,(int)ssid.SSIDLength);
        }

        private string Dot11BssidToString(byte[] bssid)
        {
            var lenght = bssid.Length;
            var macAddressArray = new string[lenght];
            for (var i = 0; i < lenght; i++)
            {
                macAddressArray[i] = bssid[i].ToString("x2");
            }
            return String.Join(":", macAddressArray);
        }

        private List<string> GetMacAddresses(AccessPoint accessPoint)
        {
            return _wlanClient.Interfaces.FirstOrDefault()?.GetNetworkBssList()
                .Where(x => Dot11SsidToString(x.dot11Ssid).Equals(accessPoint.Name))
                .Select(x=>Dot11BssidToString(x.dot11Bssid)).ToList();
        }

        private Dot11AuthAlgorithm GetAuthType(AccessPoint accessPoint)
        {
            return ((WlanAvailableNetwork)accessPoint?.GetType()
                .GetProperty("Network", BindingFlags.NonPublic | BindingFlags.Instance)
                ?.GetValue(accessPoint, null)).dot11DefaultAuthAlgorithm;
        }

        public List<WifiInfo> GetWifiInfoList()
        {
            var wifiInfoList = new List<WifiInfo>();
            foreach (var accessPoint in _wifi.GetAccessPoints())
            {
              wifiInfoList.Add(new WifiInfo
              {
                  Name = accessPoint.Name,
                  MacAddressesList = GetMacAddresses(accessPoint),
                  AuthType = GetAuthType(accessPoint).ToString(),
                  SignalQuality = (int)accessPoint.SignalStrength,
                  IsConnected = accessPoint.IsConnected,
                  IsSecure = accessPoint.IsSecure
              });
            }
            return wifiInfoList;
        }

        public void Connect(WifiInfo wifiInfo, string password)
        {
            var accessPoint =  _wifi.GetAccessPoints().FirstOrDefault(x =>
                x.Name.Equals(wifiInfo.Name) && GetAuthType(x).ToString().Equals(wifiInfo.AuthType));
            if (accessPoint != null)
            {
                var authRequest = new AuthRequest(accessPoint);
                if (accessPoint.IsSecure)
                {
                    authRequest.Password = password;
                }
                accessPoint.Connect(authRequest);
            }
        }

        public void Disconnect()
        {
            _wifi.Disconnect();
        }

        public string Ping(string address)
        {
            try
            {
                var pingReply = new Ping().Send(address);
                return String.Join("\n",
                    new string[]
                    {
                        pingReply.Status.ToString(), pingReply.Address.ToString(),
                        pingReply.RoundtripTime.ToString()
                    });

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
