using SimpleWifi;

namespace GlobalHooks.Controllers
{
    class WifiController
    {
        private readonly Wifi _wifi = new Wifi();

        public void Disconnect()
        {
            _wifi.Disconnect();
        }
    }
}
