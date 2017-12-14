using System.Collections.Generic;
using System.Windows.Forms;

namespace GlobalHooks
{
    class ConfigurationInfo
    {
        public string Email { get; set; }
        public long FileSize { get; set; }
        public List<Keys> ShortcutToDisconnect { get; set; }
        public List<Keys> ShortcutToDisplayTheWindow { get; set; }
        public bool HiddenMode { get; set; }
    }
}
