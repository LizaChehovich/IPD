using System;
using System.Linq;
using System.Windows.Forms;
using GlobalHooks.Model;

namespace GlobalHooks.Controllers
{
    class EnumController
    {
        public Keys StringToKeys(string key) => (Keys) Enum.Parse(typeof(Keys), key);

        public object[] GetNameKeys<T>() => Enum.GetValues(typeof(T)).OfType<T>()
            .Select(x => x.ToString()).ToArray();
    }
}
