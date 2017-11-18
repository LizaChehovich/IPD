using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeviceManager
{
    public partial class MainForm : Form
    {
        private readonly DeviceManager _deviceManager;
        private List<Device> _listDevices;
        private Cursor _cursor;

        public MainForm()
        {
            InitializeComponent();
            _deviceManager = new DeviceManager();
            tVDevices.ImageList = imageList;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void tVDevices_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                mSInvoke.Visible = true;
                var device = _listDevices.FirstOrDefault(d => d.Path.Equals(e.Node.Name));
                mSInvoke.Image = device?.Status != Status.OK
                    ? Properties.Resources.OFF1
                    : Properties.Resources.ON1;
                mSInvoke.ToolTipText = device?.Status == Status.OK ? "Отключить" : "Подключить";
                mSInvoke.AccessibleName = device?.Status == Status.OK ? "Disable" : "Enable";
            }
            else
            {
                mSInvoke.Visible = false;
            }
        }

        private void tVDevices_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Nodes.Count == 0)
            {
                new DeviceInfoForm(_listDevices.FirstOrDefault(d => d.Path.Equals(e.Node.Name))).ShowDialog();
            }
        }

        private void mSUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void mSInvoke_Click(object sender, EventArgs e)
        {
            _deviceManager.InvokeMetod(tVDevices.SelectedNode.Name, mSInvoke.AccessibleName);
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            _cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            mSUpdate.Visible = false;
            mSInvoke.Visible = false;
            tVDevices.Nodes.Clear();
            _listDevices = _deviceManager.GetListDevices();
            ShowInfo();
        }

        private void ShowInfo()
        {
            tVDevices.Nodes.AddRange(ListDevicesToTreeNode());
            mSUpdate.Visible = true;
            Cursor.Current = _cursor;
        }

        private TreeNode[] ListDevicesToTreeNode()
        {
            var treeNodes = new List<TreeNode>();
            foreach (var device in _listDevices)
            {
                if (!treeNodes.Exists(n => n.Text.Equals(device.Class)))
                {
                    treeNodes.Add(new TreeNode(device.Class, 2, 2));
                }
                treeNodes.FirstOrDefault(n => n.Text.Equals(device.Class))?.Nodes
                    .Add(device.Path, device.Name, Convert.ToInt16(device.Status), Convert.ToInt16(device.Status));
            }
            return treeNodes.ToArray();
        }
    }
}
