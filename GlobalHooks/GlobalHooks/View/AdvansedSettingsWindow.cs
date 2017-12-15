using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GlobalHooks.Controllers;
using GlobalHooks.Model;

namespace GlobalHooks.View
{
    public partial class AdvansedSettingsWindow : Form
    {
        private readonly ConfigurationInfo _configuration;
        private readonly EnumController _enum = new EnumController();

        public AdvansedSettingsWindow(ConfigurationInfo configuration)
        {
            InitializeComponent();
            _configuration = configuration;
            InitializeGroupBoxAdvansedSettings();
        }

        private void btSaveAdvansedSettings_Click(object sender, EventArgs e)
        {
            if (!new EmailController().IsValidEmail(tbFrom.Text))
            {
                MessageBox.Show(@"Неверный формат email", @"Ошибка");
                return;
            }
            if (tbPassword.Text.Length == 0)
            {
                MessageBox.Show(@"Введите пароль", @"Ошибка");
                return;
            }
            UpdateSettings();
            Close();
        }

        private void btAbortAdvansedSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbShow1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeSelectedItems(cbShow1, new[] { cbShow2 });
        }

        private void cbShow2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeSelectedItems(cbShow2, new[] { cbShow1 });
        }

        private void cbSettings1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeSelectedItems(cbSettings1, new[] { cbSettings2, cbSettings3 });
        }

        private void cbSettings2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeSelectedItems(cbSettings2, new[] { cbSettings1, cbSettings3 });
        }

        private void cbSettings3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeSelectedItems(cbSettings3, new[] { cbSettings1, cbSettings2 });
        }

        private void InitializeGroupBoxAdvansedSettings()
        {
            tbFrom.Text = _configuration.From;
            tbPassword.Text = _configuration.Password;
            InitializeComboBoxes();
            SetSelectedItemsComboBox();
        }

        private void InitializeComboBoxes()
        {
            cbDisconnect1.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbDisconnect2.Items.AddRange(_enum.GetNameKeys<AlphanumericKeys>());
            cbShow1.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbShow2.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbShow3.Items.AddRange(_enum.GetNameKeys<AlphanumericKeys>());
            cbSettings1.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbSettings2.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbSettings3.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
            cbSettings4.Items.AddRange(_enum.GetNameKeys<AlphanumericKeys>());
        }

        private void SetSelectedItemsComboBox()
        {
            SetSelectedItemsDisconnect();
            SetSelectedItemsShow();
            SetSelectedItemsSettings();
        }

        private void SetSelectedItemsDisconnect()
        {
            cbDisconnect1.SelectedItem = _configuration.ShortcutToDisconnect[0].ToString();
            cbDisconnect2.SelectedItem = _configuration.ShortcutToDisconnect[1].ToString();
        }

        private void SetSelectedItemsShow()
        {
            RemoveItemsFromComboBox(cbShow1, new[] { _configuration.ShortcutToDisplayTheWindow[1] });
            RemoveItemsFromComboBox(cbShow2, new[] { _configuration.ShortcutToDisplayTheWindow[0] });
            cbShow1.SelectedItem = _configuration.ShortcutToDisplayTheWindow[0].ToString();
            cbShow2.SelectedItem = _configuration.ShortcutToDisplayTheWindow[1].ToString();
            cbShow3.SelectedItem = _configuration.ShortcutToDisplayTheWindow[2].ToString();
        }

        private void SetSelectedItemsSettings()
        {
            RemoveItemsFromComboBox(cbSettings1,
                new[]
                {
                    _configuration.ShortcutToDisplayAdvancedSettings[1],
                    _configuration.ShortcutToDisplayAdvancedSettings[2]
                });
            RemoveItemsFromComboBox(cbSettings2,
                new[]
                {
                    _configuration.ShortcutToDisplayAdvancedSettings[0],
                    _configuration.ShortcutToDisplayAdvancedSettings[2]
                });
            RemoveItemsFromComboBox(cbSettings3,
                new[]
                {
                    _configuration.ShortcutToDisplayAdvancedSettings[0],
                    _configuration.ShortcutToDisplayAdvancedSettings[1]
                });
            cbSettings1.SelectedItem = _configuration.ShortcutToDisplayAdvancedSettings[0].ToString();
            cbSettings2.SelectedItem = _configuration.ShortcutToDisplayAdvancedSettings[1].ToString();
            cbSettings3.SelectedItem = _configuration.ShortcutToDisplayAdvancedSettings[2].ToString();
            cbSettings4.SelectedItem = _configuration.ShortcutToDisplayAdvancedSettings[3].ToString();
        }

        private void RemoveItemsFromComboBox(ComboBox comboBox, Keys[] keys)
        {
            foreach (var key in keys)
            {
                comboBox.Items.Remove(key.ToString());
            }
        }

        private void ChangeSelectedItems(ComboBox changedBox, ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                var select = comboBox.SelectedItem?.ToString();
                comboBox.Items.Clear();
                comboBox.Items.AddRange(_enum.GetNameKeys<ServiceKeys>());
                comboBox.Items.Remove(changedBox.SelectedItem.ToString());
                foreach (var comBox in comboBoxes)
                {
                    if (comBox == comboBox) continue;
                    comboBox.Items.Remove(comBox.SelectedItem.ToString());
                }
                comboBox.SelectedItem = select;
            }
        }

        private void UpdateSettings()
        {
            _configuration.From = tbFrom.Text;
            _configuration.Password = tbPassword.Text;
            _configuration.ShortcutToDisconnect = new List<Keys>()
            {
                _enum.StringToKeys(cbDisconnect1.SelectedItem.ToString()),
                _enum.StringToKeys(cbDisconnect2.SelectedItem.ToString())
            };
            _configuration.ShortcutToDisplayTheWindow = new List<Keys>()
            {
                _enum.StringToKeys(cbShow1.SelectedItem.ToString()),
                _enum.StringToKeys(cbShow2.SelectedItem.ToString()),
                _enum.StringToKeys(cbShow3.SelectedItem.ToString())
            };
            _configuration.ShortcutToDisplayAdvancedSettings = new List<Keys>()
            {
                _enum.StringToKeys(cbSettings1.SelectedItem.ToString()),
                _enum.StringToKeys(cbSettings2.SelectedItem.ToString()),
                _enum.StringToKeys(cbSettings3.SelectedItem.ToString()),
                _enum.StringToKeys(cbSettings4.SelectedItem.ToString())
            };
        }
    }
}
