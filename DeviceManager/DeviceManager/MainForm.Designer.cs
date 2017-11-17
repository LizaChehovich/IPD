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
            this.lBDevices = new System.Windows.Forms.ListBox();
            this.tBGUID = new System.Windows.Forms.TextBox();
            this.tBHardwareIDs = new System.Windows.Forms.TextBox();
            this.tBManufacturer = new System.Windows.Forms.TextBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.tBStatus = new System.Windows.Forms.TextBox();
            this.dGVDrivers = new System.Windows.Forms.DataGridView();
            this.descriptionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEnable = new System.Windows.Forms.Button();
            this.btDisable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lBDevices
            // 
            this.lBDevices.FormattingEnabled = true;
            this.lBDevices.ItemHeight = 16;
            this.lBDevices.Location = new System.Drawing.Point(12, 12);
            this.lBDevices.Name = "lBDevices";
            this.lBDevices.Size = new System.Drawing.Size(377, 468);
            this.lBDevices.TabIndex = 0;
            this.lBDevices.SelectedIndexChanged += new System.EventHandler(this.lBDevices_SelectedIndexChanged);
            // 
            // tBGUID
            // 
            this.tBGUID.Location = new System.Drawing.Point(557, 10);
            this.tBGUID.Name = "tBGUID";
            this.tBGUID.Size = new System.Drawing.Size(346, 22);
            this.tBGUID.TabIndex = 1;
            // 
            // tBHardwareIDs
            // 
            this.tBHardwareIDs.Location = new System.Drawing.Point(557, 39);
            this.tBHardwareIDs.Multiline = true;
            this.tBHardwareIDs.Name = "tBHardwareIDs";
            this.tBHardwareIDs.Size = new System.Drawing.Size(346, 100);
            this.tBHardwareIDs.TabIndex = 2;
            // 
            // tBManufacturer
            // 
            this.tBManufacturer.Location = new System.Drawing.Point(557, 146);
            this.tBManufacturer.Name = "tBManufacturer";
            this.tBManufacturer.Size = new System.Drawing.Size(346, 22);
            this.tBManufacturer.TabIndex = 3;
            // 
            // tBPath
            // 
            this.tBPath.Location = new System.Drawing.Point(557, 175);
            this.tBPath.Name = "tBPath";
            this.tBPath.Size = new System.Drawing.Size(346, 22);
            this.tBPath.TabIndex = 4;
            // 
            // tBStatus
            // 
            this.tBStatus.Location = new System.Drawing.Point(557, 204);
            this.tBStatus.Name = "tBStatus";
            this.tBStatus.Size = new System.Drawing.Size(346, 22);
            this.tBStatus.TabIndex = 5;
            // 
            // dGVDrivers
            // 
            this.dGVDrivers.AllowUserToAddRows = false;
            this.dGVDrivers.AllowUserToDeleteRows = false;
            this.dGVDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionsColumn,
            this.sysPathColumn});
            this.dGVDrivers.Location = new System.Drawing.Point(405, 254);
            this.dGVDrivers.Name = "dGVDrivers";
            this.dGVDrivers.ReadOnly = true;
            this.dGVDrivers.RowTemplate.Height = 24;
            this.dGVDrivers.Size = new System.Drawing.Size(498, 150);
            this.dGVDrivers.TabIndex = 6;
            // 
            // descriptionsColumn
            // 
            this.descriptionsColumn.HeaderText = "Описание";
            this.descriptionsColumn.Name = "descriptionsColumn";
            this.descriptionsColumn.ReadOnly = true;
            // 
            // sysPathColumn
            // 
            this.sysPathColumn.HeaderText = "Путь к .sys-файлу";
            this.sysPathColumn.Name = "sysPathColumn";
            this.sysPathColumn.ReadOnly = true;
            // 
            // btEnable
            // 
            this.btEnable.Location = new System.Drawing.Point(557, 430);
            this.btEnable.Name = "btEnable";
            this.btEnable.Size = new System.Drawing.Size(101, 35);
            this.btEnable.TabIndex = 7;
            this.btEnable.Text = "Подключить";
            this.btEnable.UseVisualStyleBackColor = true;
            this.btEnable.Click += new System.EventHandler(this.btEnable_Click);
            // 
            // btDisable
            // 
            this.btDisable.Location = new System.Drawing.Point(681, 430);
            this.btDisable.Name = "btDisable";
            this.btDisable.Size = new System.Drawing.Size(101, 35);
            this.btDisable.TabIndex = 8;
            this.btDisable.Text = "Отключить";
            this.btDisable.UseVisualStyleBackColor = true;
            this.btDisable.Click += new System.EventHandler(this.btDisable_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 494);
            this.Controls.Add(this.btDisable);
            this.Controls.Add(this.btEnable);
            this.Controls.Add(this.dGVDrivers);
            this.Controls.Add(this.tBStatus);
            this.Controls.Add(this.tBPath);
            this.Controls.Add(this.tBManufacturer);
            this.Controls.Add(this.tBHardwareIDs);
            this.Controls.Add(this.tBGUID);
            this.Controls.Add(this.lBDevices);
            this.Name = "MainForm";
            this.Text = "Диспетчер устройств";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBDevices;
        private System.Windows.Forms.TextBox tBGUID;
        private System.Windows.Forms.TextBox tBHardwareIDs;
        private System.Windows.Forms.TextBox tBManufacturer;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.TextBox tBStatus;
        private System.Windows.Forms.DataGridView dGVDrivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysPathColumn;
        private System.Windows.Forms.Button btEnable;
        private System.Windows.Forms.Button btDisable;
    }
}

