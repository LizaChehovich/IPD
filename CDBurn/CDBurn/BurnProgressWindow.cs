using System;
using System.Threading;
using System.Windows.Forms;
using IMAPI2;

namespace CDBurn
{
    public partial class BurnProgressWindow : Form
    {
        private FormatDataWriteAction _writeAction;

        public BurnProgressWindow(BurnManager burnManager)
        {
            InitializeComponent();
            burnManager.UpdateBurn += UpdateProgressBar;
            new Thread(burnManager.Burn).Start();
        }

        private void UpdateProgressBar(FormatWriteUpdateEventArgs e)
        {
            ProgressBar.Value = (e.LastWrittenLba - e.StartLba + 1) * 100 / e.SectorCount;
            UpdateBurnState(e._currentAction);
        }

        private void UpdateBurnState(FormatDataWriteAction action)
        {
            if (action.Equals(_writeAction))
                return;
            _writeAction = action;
            btOK.Enabled = _writeAction == FormatDataWriteAction.Completed;
            lbWriteAction.Text = FormatDataWriteActionToRussian(action);
            if (WindowState != FormWindowState.Minimized) return;
            notifyIcon.BalloonTipText = FormatDataWriteActionToRussian(action);
            notifyIcon.ShowBalloonTip(50);
        }

        private string FormatDataWriteActionToRussian(FormatDataWriteAction action)
        {
            string actionName;
            switch (action)
            {
                case FormatDataWriteAction.CalibratingPower:
                    actionName = @"Калибровка мощности";
                    break;
                case FormatDataWriteAction.Completed:
                    actionName = @"Завершено";
                    break;
                case FormatDataWriteAction.ValidatingMedia:
                    actionName = @"Проверка носителя";
                    break;
                case FormatDataWriteAction.FormattingMedia:
                    actionName = @"Форматирование";
                    break;
                case FormatDataWriteAction.InitializingHardware:
                    actionName = @"Инициализация оборудования";
                    break;
                case FormatDataWriteAction.WritingData:
                    actionName = @"Запись данных";
                    break;
                case FormatDataWriteAction.Finalization:
                    actionName = @"Завершение";
                    break;
                case FormatDataWriteAction.Verifying:
                    actionName = @"Проверка";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
            return actionName;
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
            if (_writeAction == FormatDataWriteAction.Completed)
                e.Cancel = false;
            else
            {
                e.Cancel = true;
                MessageBox.Show(@"Дождитесь завершения записи на диск", @"Ошибка");
            }
        }
    }
}
