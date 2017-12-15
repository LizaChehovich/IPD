using System.Collections.Generic;
using System.Windows.Forms;

namespace GlobalHooks.Model
{
    class ConfigurationInfo
    {
        public string To { get; set; }
        public long FileSize { get; set; }
        public bool HiddenMode { get; set; }
        public string From { get; set; }
        public string Password { get; set; }

        private List<Keys> _shortcutToDisconnect;

        public List<Keys> ShortcutToDisconnect
        {
            get => _shortcutToDisconnect;
            set => _shortcutToDisconnect =
                (value == null || value.Count != 2) ? new List<Keys>() {Keys.Alt, Keys.D} : value;
        }

        private List<Keys> _shortcutToDisplayTheWindow;

        public List<Keys> ShortcutToDisplayTheWindow
        {
            get => _shortcutToDisplayTheWindow;
            set => _shortcutToDisplayTheWindow= (value == null || value.Count != 3)
                ? new List<Keys>() {Keys.Control, Keys.Shift, Keys.S}
                : value;
        }

        private List<Keys> _shortcutToDisplayAdvancedSettings;

        public List<Keys> ShortcutToDisplayAdvancedSettings
        {
            get => _shortcutToDisplayAdvancedSettings;
            set => _shortcutToDisplayAdvancedSettings = (value == null || value.Count != 4)
                ? new List<Keys>() {Keys.Control, Keys.Alt, Keys.Shift, Keys.V}
                : value;
        }
    }
}
