namespace DeviceManager
{
    partial class DeviceInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceInfoForm));
            this.tCInfo = new System.Windows.Forms.TabControl();
            this.tPCommon = new System.Windows.Forms.TabPage();
            this.tBState = new System.Windows.Forms.TextBox();
            this.tBPath = new System.Windows.Forms.TextBox();
            this.tBManufacturer = new System.Windows.Forms.TextBox();
            this.tbHIDs = new System.Windows.Forms.TextBox();
            this.tBGUID = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbHardwareIDs = new System.Windows.Forms.Label();
            this.lbGUID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tPDriversInfo = new System.Windows.Forms.TabPage();
            this.lbDriverPath = new System.Windows.Forms.Label();
            this.lbDriver = new System.Windows.Forms.Label();
            this.lBDrivers = new System.Windows.Forms.ListBox();
            this.tBDriverPath = new System.Windows.Forms.TextBox();
            this.tBClass = new System.Windows.Forms.TextBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.tCInfo.SuspendLayout();
            this.tPCommon.SuspendLayout();
            this.tPDriversInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCInfo
            // 
            this.tCInfo.Controls.Add(this.tPCommon);
            this.tCInfo.Controls.Add(this.tPDriversInfo);
            this.tCInfo.Location = new System.Drawing.Point(18, 19);
            this.tCInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tCInfo.Name = "tCInfo";
            this.tCInfo.SelectedIndex = 0;
            this.tCInfo.Size = new System.Drawing.Size(668, 704);
            this.tCInfo.TabIndex = 0;
            // 
            // tPCommon
            // 
            this.tPCommon.BackColor = System.Drawing.Color.LavenderBlush;
            this.tPCommon.Controls.Add(this.tBClass);
            this.tPCommon.Controls.Add(this.lbClass);
            this.tPCommon.Controls.Add(this.tBState);
            this.tPCommon.Controls.Add(this.tBPath);
            this.tPCommon.Controls.Add(this.tBManufacturer);
            this.tPCommon.Controls.Add(this.tbHIDs);
            this.tPCommon.Controls.Add(this.tBGUID);
            this.tPCommon.Controls.Add(this.tBName);
            this.tPCommon.Controls.Add(this.lbState);
            this.tPCommon.Controls.Add(this.lbPath);
            this.tPCommon.Controls.Add(this.lbManufacturer);
            this.tPCommon.Controls.Add(this.lbHardwareIDs);
            this.tPCommon.Controls.Add(this.lbGUID);
            this.tPCommon.Controls.Add(this.lbName);
            this.tPCommon.Location = new System.Drawing.Point(4, 34);
            this.tPCommon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPCommon.Name = "tPCommon";
            this.tPCommon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPCommon.Size = new System.Drawing.Size(660, 666);
            this.tPCommon.TabIndex = 0;
            this.tPCommon.Text = "Общие";
            // 
            // tBState
            // 
            this.tBState.Location = new System.Drawing.Point(226, 590);
            this.tBState.Name = "tBState";
            this.tBState.ReadOnly = true;
            this.tBState.Size = new System.Drawing.Size(369, 30);
            this.tBState.TabIndex = 11;
            // 
            // tBPath
            // 
            this.tBPath.Location = new System.Drawing.Point(226, 441);
            this.tBPath.Multiline = true;
            this.tBPath.Name = "tBPath";
            this.tBPath.ReadOnly = true;
            this.tBPath.Size = new System.Drawing.Size(369, 119);
            this.tBPath.TabIndex = 10;
            // 
            // tBManufacturer
            // 
            this.tBManufacturer.Location = new System.Drawing.Point(226, 382);
            this.tBManufacturer.Name = "tBManufacturer";
            this.tBManufacturer.ReadOnly = true;
            this.tBManufacturer.Size = new System.Drawing.Size(369, 30);
            this.tBManufacturer.TabIndex = 9;
            // 
            // tbHIDs
            // 
            this.tbHIDs.Location = new System.Drawing.Point(226, 205);
            this.tbHIDs.Multiline = true;
            this.tbHIDs.Name = "tbHIDs";
            this.tbHIDs.ReadOnly = true;
            this.tbHIDs.Size = new System.Drawing.Size(369, 145);
            this.tbHIDs.TabIndex = 8;
            // 
            // tBGUID
            // 
            this.tBGUID.Location = new System.Drawing.Point(226, 146);
            this.tBGUID.Name = "tBGUID";
            this.tBGUID.ReadOnly = true;
            this.tBGUID.Size = new System.Drawing.Size(369, 30);
            this.tBGUID.TabIndex = 7;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(226, 32);
            this.tBName.Name = "tBName";
            this.tBName.ReadOnly = true;
            this.tBName.Size = new System.Drawing.Size(369, 30);
            this.tBName.TabIndex = 6;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(54, 595);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(119, 25);
            this.lbState.TabIndex = 5;
            this.lbState.Text = "Состояние:";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(54, 446);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(63, 25);
            this.lbPath.TabIndex = 4;
            this.lbPath.Text = "Путь:";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(54, 387);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(165, 25);
            this.lbManufacturer.TabIndex = 3;
            this.lbManufacturer.Text = "Производитель:";
            // 
            // lbHardwareIDs
            // 
            this.lbHardwareIDs.AutoSize = true;
            this.lbHardwareIDs.Location = new System.Drawing.Point(54, 210);
            this.lbHardwareIDs.Name = "lbHardwareIDs";
            this.lbHardwareIDs.Size = new System.Drawing.Size(131, 25);
            this.lbHardwareIDs.TabIndex = 2;
            this.lbHardwareIDs.Text = "HardwareIDs:";
            // 
            // lbGUID
            // 
            this.lbGUID.AutoSize = true;
            this.lbGUID.Location = new System.Drawing.Point(54, 151);
            this.lbGUID.Name = "lbGUID";
            this.lbGUID.Size = new System.Drawing.Size(66, 25);
            this.lbGUID.TabIndex = 1;
            this.lbGUID.Text = "GUID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(54, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(105, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название:";
            // 
            // tPDriversInfo
            // 
            this.tPDriversInfo.BackColor = System.Drawing.Color.LavenderBlush;
            this.tPDriversInfo.Controls.Add(this.tBDriverPath);
            this.tPDriversInfo.Controls.Add(this.lbDriverPath);
            this.tPDriversInfo.Controls.Add(this.lbDriver);
            this.tPDriversInfo.Controls.Add(this.lBDrivers);
            this.tPDriversInfo.Location = new System.Drawing.Point(4, 34);
            this.tPDriversInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPDriversInfo.Name = "tPDriversInfo";
            this.tPDriversInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPDriversInfo.Size = new System.Drawing.Size(660, 666);
            this.tPDriversInfo.TabIndex = 1;
            this.tPDriversInfo.Text = "Драйвер";
            // 
            // lbDriverPath
            // 
            this.lbDriverPath.AutoSize = true;
            this.lbDriverPath.Location = new System.Drawing.Point(21, 465);
            this.lbDriverPath.Name = "lbDriverPath";
            this.lbDriverPath.Size = new System.Drawing.Size(186, 25);
            this.lbDriverPath.TabIndex = 2;
            this.lbDriverPath.Text = "Путь к .sys-файлу:";
            // 
            // lbDriver
            // 
            this.lbDriver.AutoSize = true;
            this.lbDriver.Location = new System.Drawing.Point(21, 20);
            this.lbDriver.Name = "lbDriver";
            this.lbDriver.Size = new System.Drawing.Size(99, 25);
            this.lbDriver.TabIndex = 1;
            this.lbDriver.Text = "Драйвер:";
            // 
            // lBDrivers
            // 
            this.lBDrivers.FormattingEnabled = true;
            this.lBDrivers.ItemHeight = 25;
            this.lBDrivers.Location = new System.Drawing.Point(26, 48);
            this.lBDrivers.Name = "lBDrivers";
            this.lBDrivers.Size = new System.Drawing.Size(605, 379);
            this.lBDrivers.TabIndex = 0;
            this.lBDrivers.SelectedIndexChanged += new System.EventHandler(this.lBDrivers_SelectedIndexChanged);
            // 
            // tBDriverPath
            // 
            this.tBDriverPath.Location = new System.Drawing.Point(26, 493);
            this.tBDriverPath.Multiline = true;
            this.tBDriverPath.Name = "tBDriverPath";
            this.tBDriverPath.ReadOnly = true;
            this.tBDriverPath.Size = new System.Drawing.Size(605, 143);
            this.tBDriverPath.TabIndex = 9;
            // 
            // tBClass
            // 
            this.tBClass.Location = new System.Drawing.Point(226, 87);
            this.tBClass.Name = "tBClass";
            this.tBClass.ReadOnly = true;
            this.tBClass.Size = new System.Drawing.Size(369, 30);
            this.tBClass.TabIndex = 13;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(54, 92);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(72, 25);
            this.lbClass.TabIndex = 12;
            this.lbClass.Text = "Класс:";
            // 
            // DeviceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(704, 746);
            this.Controls.Add(this.tCInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeviceInfoForm";
            this.Text = "Информация об устройстве";
            this.tCInfo.ResumeLayout(false);
            this.tPCommon.ResumeLayout(false);
            this.tPCommon.PerformLayout();
            this.tPDriversInfo.ResumeLayout(false);
            this.tPDriversInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCInfo;
        private System.Windows.Forms.TabPage tPCommon;
        private System.Windows.Forms.TabPage tPDriversInfo;
        private System.Windows.Forms.Label lbGUID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHardwareIDs;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tBState;
        private System.Windows.Forms.TextBox tBPath;
        private System.Windows.Forms.TextBox tBManufacturer;
        private System.Windows.Forms.TextBox tbHIDs;
        private System.Windows.Forms.TextBox tBGUID;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.ListBox lBDrivers;
        private System.Windows.Forms.Label lbDriverPath;
        private System.Windows.Forms.Label lbDriver;
        private System.Windows.Forms.TextBox tBDriverPath;
        private System.Windows.Forms.TextBox tBClass;
        private System.Windows.Forms.Label lbClass;
    }
}