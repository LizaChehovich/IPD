namespace DeviceManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tVDevices = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.mSUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mSInvoke = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.MediumOrchid;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSUpdate,
            this.mSInvoke});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.ShowItemToolTips = true;
            this.menu.Size = new System.Drawing.Size(974, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // tVDevices
            // 
            this.tVDevices.BackColor = System.Drawing.Color.LavenderBlush;
            this.tVDevices.Location = new System.Drawing.Point(18, 58);
            this.tVDevices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tVDevices.Name = "tVDevices";
            this.tVDevices.Size = new System.Drawing.Size(936, 674);
            this.tVDevices.Sorted = true;
            this.tVDevices.TabIndex = 0;
            this.tVDevices.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tVDevices_NodeMouseClick);
            this.tVDevices.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tVDevices_NodeMouseDoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "OK.png");
            this.imageList.Images.SetKeyName(1, "Error.png");
            this.imageList.Images.SetKeyName(2, "Empty.PNG");
            // 
            // mSUpdate
            // 
            this.mSUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mSUpdate.Image = global::DeviceManager.Properties.Resources.update;
            this.mSUpdate.Name = "mSUpdate";
            this.mSUpdate.Size = new System.Drawing.Size(32, 24);
            this.mSUpdate.Text = "Обновить";
            this.mSUpdate.ToolTipText = "Обновить";
            this.mSUpdate.Visible = false;
            this.mSUpdate.Click += new System.EventHandler(this.mSUpdate_Click);
            // 
            // mSInvoke
            // 
            this.mSInvoke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mSInvoke.Image = global::DeviceManager.Properties.Resources.ON1;
            this.mSInvoke.Name = "mSInvoke";
            this.mSInvoke.Size = new System.Drawing.Size(32, 24);
            this.mSInvoke.Text = "mSInvoke";
            this.mSInvoke.Visible = false;
            this.mSInvoke.Click += new System.EventHandler(this.mSInvoke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Устройства:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(974, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tVDevices);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Диспетчер устройств";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mSUpdate;
        private System.Windows.Forms.ToolStripMenuItem mSInvoke;
        private System.Windows.Forms.TreeView tVDevices;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label label1;
    }
}

