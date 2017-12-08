using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using IMAPI2;

namespace CDBurn
{
    public partial class MainWindow : Form
    {
        private readonly BurnManager _burnManager = new BurnManager();
        private readonly FileManager _fileManager = new FileManager();
        private const long BytesInMegabyte = 1024 * 1024;

        public MainWindow()
        {
            InitializeComponent();
            UpdateGuiBurnPage();
        }

        private void UpdateGuiBurnPage()
        {
            cbDiscRecorders.Items.Clear();
            cbDiscRecorders.Items.AddRange(DiscRecordersToStringArray(_burnManager.RecordersList));
            tbType.Text = string.Empty;
            tbSize.Text = string.Empty;
            gbFiles.Enabled = false;
            lbFiles.Items.Clear();
            UsedSpaceBar.Value = 0;
            UsedSpaceBar.Caption = string.Empty;
        }

        private void UpdateGuiFormatPage()
        {
            cbDisc.Items.Clear();
            cbDisc.Items.AddRange(DiscRecordersToStringArray(_burnManager.RecordersList));
        }

        private object[] DiscRecordersToStringArray(List<DiscRecorder> discRecorders) => discRecorders
            .Select(discRecorder => string.Join(" ", discRecorder.VolumePath, discRecorder.RecorderId)).ToArray();

        private void FillDiscInfo(Disc disc)
        {
            tbType.Text = disc.Type.ToString();
            tbSize.Text = $@"{disc.Size / BytesInMegabyte} MB";
            if (disc.Type == PhysicalMedia.Unknown)
            {
                ShowMessageBox(@"Диск не поддерживается");
                gbFiles.Enabled = false;
                return;
            }
            if (disc.State != MediaState.Blank)
            {
                ShowMessageBox(@"Диск уже занят. Перед записью новых данных необходимо удалить старые");
                gbFiles.Enabled = false;
            }
            else
            {
                InitializeFilesBox(disc.Size);
            }
        }

        private void InitializeFilesBox(long discSize)
        {
            gbFiles.Enabled = true;
            lbFiles.Items.Clear();
            _fileManager.RemoveFiles();
            _fileManager.DiscSize = discSize;
            UsedSpaceBar.Value = 0;
            UsedSpaceBar.Maximum = (int)(discSize / BytesInMegabyte);
            UsedSpaceBar.Caption = GetUsedSpaceBarCaption;
            btAddFile.Enabled = true;
            btRemoveFile.Enabled = false;
            btBurn.Enabled = false;
        }

        private string GetUsedSpaceBarCaption => $@"{_fileManager.FilesSize / BytesInMegabyte}/{_fileManager.DiscSize / BytesInMegabyte} MB";

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message, @"Ошибка");
        }

        private void UpdateFilesBox()
        {
            lbFiles.Items.Clear();
            lbFiles.Items.AddRange(FileListToStringArray(_fileManager.FileToBurningList));
            UsedSpaceBar.Value = (int) (_fileManager.FilesSize / BytesInMegabyte);
            UsedSpaceBar.Caption = GetUsedSpaceBarCaption;
            btBurn.Enabled = _fileManager.FilesSize > 0;
            btRemoveFile.Enabled = false;
        }

        private object[] FileListToStringArray(IReadOnlyCollection<FileNode> fileList) =>
            fileList.Select(file => file.Name).ToArray();

        private void cbDiscRecorders_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDiscInfo(_burnManager.GetDiscInfo(
                cbDiscRecorders.SelectedItem.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)));
        }

        private void btUpdateDiscRecorders_Click(object sender, EventArgs e)
        {
            UpdateGuiBurnPage();
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btRemoveFile.Enabled = lbFiles.SelectedIndex != -1;
        }

        private void btAddFile_Click(object sender, EventArgs e)
        {
            if (!CheckDiscIsAviable()) return;
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (!CheckDiscIsAviable()) return;
            _fileManager.AddNewFiles(openFileDialog.FileNames);
            UpdateFilesBox();
        }

        private bool CheckDiscIsAviable()
        {
            if (_burnManager.DiskIsAviable()) return true;
            ShowMessageBox(@"Диск не доступен");
            return false;
        }

        private void btRemoveFile_Click(object sender, EventArgs e)
        {
            _fileManager.RemoveFile(lbFiles.SelectedIndex);
            UpdateFilesBox();
        }

        private void btBurn_Click(object sender, EventArgs e)
        {
            if(!CheckDiscIsAviable()) return;
            _burnManager.SetFilesToBurning(_fileManager.FileToBurningList.ToList());
            Hide();
            var progressWindow = new BurnProgressWindow(_burnManager);
            progressWindow.FormClosed += ShowWindow;
            progressWindow.Show();
        }

        private void ShowWindow(object sender, EventArgs e)
        {
            Show();
            UpdateGuiBurnPage();
        }

        private void tcFunction_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 0)
                UpdateGuiBurnPage();
            else
                UpdateGuiFormatPage();
        }

        private void btFormat_Click(object sender, EventArgs e)
        {
            _burnManager.Format();
        }

        private void cbDisc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var disc = _burnManager.GetDiscInfo(
                cbDisc.SelectedItem.ToString().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries));
            tbSizeF.Text = $@"{disc.Size / BytesInMegabyte} MB";
            tbTypeF.Text = disc.Type.ToString();
            btFormat.Enabled = false;
            if (disc.Type == PhysicalMedia.Unknown)
            {
                ShowMessageBox(@"Диск не поддерживается");
                return;
            }
            if (disc.State == MediaState.Blank)
            {
                ShowMessageBox(@"Диск свободен");
            }
            else
            {
                btFormat.Enabled = true;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Minimized) return;
            notifyIcon.Visible = true;
            ShowInTaskbar = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }
    }
}