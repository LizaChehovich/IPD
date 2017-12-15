using System.Text.RegularExpressions;

namespace GlobalHooks.Controllers
{
    class EmailController
    {
        public bool IsValidEmail(string email) => new Regex("[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}").IsMatch(email.ToLower());
    }
}
