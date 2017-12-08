using System;
using System.Threading;
using System.Windows.Forms;
using IMAPI2;

namespace CDBurn
{
    public partial class BurnProgressWindow : Form
    {
        private bool _burnIsCompleted = false;

        public BurnProgressWindow(BurnManager burnManager)
        {
            InitializeComponent();
            burnManager.UpdateBurn += UpdateProgressBar;
            new Thread(burnManager.Burn).Start();
        }

        private void UpdateProgressBar(FormatWriteUpdateEventArgs e)
        {
            ProgressBar.Value = (e.LastWrittenLba - e.StartLba + 1) * 100 / e.SectorCount;
            if (ProgressBar.Value != 100) return;
            _burnIsCompleted = true;
            btOK.Enabled = true;
            notifyIcon.BalloonTipTitle = @"Запись завершена";
            notifyIcon.BalloonTipText = @"Запись завершена";
            notifyIcon.ShowBalloonTip(5000);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void BurnProgressWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized) return;
            notifyIcon.Visible = true;
            ShowInTaskbar = false;
        }

        private void BurnProgressWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_burnIsCompleted)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                MessageBox.Show(@"Дождитесь завершения записи на диск", @"Ошибка");
            }
        }
    }
}
