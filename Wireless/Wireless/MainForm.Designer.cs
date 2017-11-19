namespace Wireless
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
            this.lbxWifi = new System.Windows.Forms.ListBox();
            this.gbxCurrentWifiInfo = new System.Windows.Forms.GroupBox();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.tbxConnectedIsSecure = new System.Windows.Forms.TextBox();
            this.lbConnectedIsSecure = new System.Windows.Forms.Label();
            this.tbxConnectedMacAddress = new System.Windows.Forms.TextBox();
            this.tbxConnectedAuthType = new System.Windows.Forms.TextBox();
            this.tbxConnectedSignalQuality = new System.Windows.Forms.TextBox();
            this.tbxConnectedName = new System.Windows.Forms.TextBox();
            this.lbConnectedMacAddress = new System.Windows.Forms.Label();
            this.lbConnectedAuthType = new System.Windows.Forms.Label();
            this.lbConnectedSignalQuality = new System.Windows.Forms.Label();
            this.lbConnectedName = new System.Windows.Forms.Label();
            this.gbxWifiList = new System.Windows.Forms.GroupBox();
            this.gbxPing = new System.Windows.Forms.GroupBox();
            this.btPing = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.RichTextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.gbxWifiInfo = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btConnected = new System.Windows.Forms.Button();
            this.tbxIsSecure = new System.Windows.Forms.TextBox();
            this.lbIsSecure = new System.Windows.Forms.Label();
            this.tbxMacAddress = new System.Windows.Forms.TextBox();
            this.tbxAuthType = new System.Windows.Forms.TextBox();
            this.tbxSignalQuality = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbMacAddress = new System.Windows.Forms.Label();
            this.lbAuthType = new System.Windows.Forms.Label();
            this.lbSignalQuality = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pbxConnectedSignalQuality = new System.Windows.Forms.PictureBox();
            this.pbxSignalQuality = new System.Windows.Forms.PictureBox();
            this.gbxCurrentWifiInfo.SuspendLayout();
            this.gbxWifiList.SuspendLayout();
            this.gbxPing.SuspendLayout();
            this.gbxWifiInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnectedSignalQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignalQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxWifi
            // 
            this.lbxWifi.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbxWifi.FormattingEnabled = true;
            this.lbxWifi.ItemHeight = 25;
            this.lbxWifi.Location = new System.Drawing.Point(19, 31);
            this.lbxWifi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxWifi.Name = "lbxWifi";
            this.lbxWifi.Size = new System.Drawing.Size(292, 254);
            this.lbxWifi.TabIndex = 0;
            this.lbxWifi.SelectedIndexChanged += new System.EventHandler(this.lbxWifi_SelectedIndexChanged);
            // 
            // gbxCurrentWifiInfo
            // 
            this.gbxCurrentWifiInfo.Controls.Add(this.pbxConnectedSignalQuality);
            this.gbxCurrentWifiInfo.Controls.Add(this.btDisconnect);
            this.gbxCurrentWifiInfo.Controls.Add(this.tbxConnectedIsSecure);
            this.gbxCurrentWifiInfo.Controls.Add(this.lbConnectedIsSecure);
            this.gbxCurrentWifiInfo.Controls.Add(this.tbxConnectedMacAddress);
            this.gbxCurrentWifiInfo.Controls.Add(this.tbxConnectedAuthType);
            this.gbxCurrentWifiInfo.Controls.Add(this.tbxConnectedSignalQuality);
            this.gbxCurrentWifiInfo.Controls.Add(this.tbxConnectedName);
            this.gbxCurrentWifiInfo.Controls.Add(this.lbConnectedMacAddress);
            this.gbxCurrentWifiInfo.Controls.Add(this.lbConnectedAuthType);
            this.gbxCurrentWifiInfo.Controls.Add(this.lbConnectedSignalQuality);
            this.gbxCurrentWifiInfo.Controls.Add(this.lbConnectedName);
            this.gbxCurrentWifiInfo.Location = new System.Drawing.Point(360, 9);
            this.gbxCurrentWifiInfo.Name = "gbxCurrentWifiInfo";
            this.gbxCurrentWifiInfo.Size = new System.Drawing.Size(480, 309);
            this.gbxCurrentWifiInfo.TabIndex = 1;
            this.gbxCurrentWifiInfo.TabStop = false;
            this.gbxCurrentWifiInfo.Text = "Текущее подключение";
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.Color.LavenderBlush;
            this.btDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDisconnect.Location = new System.Drawing.Point(147, 245);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(185, 40);
            this.btDisconnect.TabIndex = 16;
            this.btDisconnect.Text = "Отключиться";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // tbxConnectedIsSecure
            // 
            this.tbxConnectedIsSecure.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxConnectedIsSecure.Location = new System.Drawing.Point(247, 132);
            this.tbxConnectedIsSecure.Name = "tbxConnectedIsSecure";
            this.tbxConnectedIsSecure.ReadOnly = true;
            this.tbxConnectedIsSecure.Size = new System.Drawing.Size(212, 30);
            this.tbxConnectedIsSecure.TabIndex = 9;
            // 
            // lbConnectedIsSecure
            // 
            this.lbConnectedIsSecure.AutoSize = true;
            this.lbConnectedIsSecure.Location = new System.Drawing.Point(242, 104);
            this.lbConnectedIsSecure.Name = "lbConnectedIsSecure";
            this.lbConnectedIsSecure.Size = new System.Drawing.Size(132, 25);
            this.lbConnectedIsSecure.TabIndex = 8;
            this.lbConnectedIsSecure.Text = "Тип защиты:";
            // 
            // tbxConnectedMacAddress
            // 
            this.tbxConnectedMacAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxConnectedMacAddress.Location = new System.Drawing.Point(24, 198);
            this.tbxConnectedMacAddress.Name = "tbxConnectedMacAddress";
            this.tbxConnectedMacAddress.ReadOnly = true;
            this.tbxConnectedMacAddress.Size = new System.Drawing.Size(435, 30);
            this.tbxConnectedMacAddress.TabIndex = 7;
            // 
            // tbxConnectedAuthType
            // 
            this.tbxConnectedAuthType.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxConnectedAuthType.Location = new System.Drawing.Point(24, 132);
            this.tbxConnectedAuthType.Name = "tbxConnectedAuthType";
            this.tbxConnectedAuthType.ReadOnly = true;
            this.tbxConnectedAuthType.Size = new System.Drawing.Size(212, 30);
            this.tbxConnectedAuthType.TabIndex = 6;
            // 
            // tbxConnectedSignalQuality
            // 
            this.tbxConnectedSignalQuality.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxConnectedSignalQuality.Location = new System.Drawing.Point(247, 57);
            this.tbxConnectedSignalQuality.Name = "tbxConnectedSignalQuality";
            this.tbxConnectedSignalQuality.ReadOnly = true;
            this.tbxConnectedSignalQuality.Size = new System.Drawing.Size(212, 30);
            this.tbxConnectedSignalQuality.TabIndex = 5;
            // 
            // tbxConnectedName
            // 
            this.tbxConnectedName.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxConnectedName.Location = new System.Drawing.Point(24, 57);
            this.tbxConnectedName.Name = "tbxConnectedName";
            this.tbxConnectedName.ReadOnly = true;
            this.tbxConnectedName.Size = new System.Drawing.Size(212, 30);
            this.tbxConnectedName.TabIndex = 4;
            // 
            // lbConnectedMacAddress
            // 
            this.lbConnectedMacAddress.AutoSize = true;
            this.lbConnectedMacAddress.Location = new System.Drawing.Point(19, 170);
            this.lbConnectedMacAddress.Name = "lbConnectedMacAddress";
            this.lbConnectedMacAddress.Size = new System.Drawing.Size(125, 25);
            this.lbConnectedMacAddress.TabIndex = 3;
            this.lbConnectedMacAddress.Text = "MAC-адрес:";
            // 
            // lbConnectedAuthType
            // 
            this.lbConnectedAuthType.AutoSize = true;
            this.lbConnectedAuthType.Location = new System.Drawing.Point(19, 104);
            this.lbConnectedAuthType.Name = "lbConnectedAuthType";
            this.lbConnectedAuthType.Size = new System.Drawing.Size(217, 25);
            this.lbConnectedAuthType.TabIndex = 2;
            this.lbConnectedAuthType.Text = "Тип аутентификации:";
            // 
            // lbConnectedSignalQuality
            // 
            this.lbConnectedSignalQuality.AutoSize = true;
            this.lbConnectedSignalQuality.Location = new System.Drawing.Point(242, 31);
            this.lbConnectedSignalQuality.Name = "lbConnectedSignalQuality";
            this.lbConnectedSignalQuality.Size = new System.Drawing.Size(182, 25);
            this.lbConnectedSignalQuality.TabIndex = 1;
            this.lbConnectedSignalQuality.Text = "Качество сигнала:";
            // 
            // lbConnectedName
            // 
            this.lbConnectedName.AutoSize = true;
            this.lbConnectedName.Location = new System.Drawing.Point(19, 31);
            this.lbConnectedName.Name = "lbConnectedName";
            this.lbConnectedName.Size = new System.Drawing.Size(105, 25);
            this.lbConnectedName.TabIndex = 0;
            this.lbConnectedName.Text = "Название:";
            // 
            // gbxWifiList
            // 
            this.gbxWifiList.Controls.Add(this.lbxWifi);
            this.gbxWifiList.Location = new System.Drawing.Point(12, 9);
            this.gbxWifiList.Name = "gbxWifiList";
            this.gbxWifiList.Size = new System.Drawing.Size(332, 309);
            this.gbxWifiList.TabIndex = 2;
            this.gbxWifiList.TabStop = false;
            this.gbxWifiList.Text = "Доступные сети";
            // 
            // gbxPing
            // 
            this.gbxPing.Controls.Add(this.btPing);
            this.gbxPing.Controls.Add(this.lbResult);
            this.gbxPing.Controls.Add(this.tbxResult);
            this.gbxPing.Controls.Add(this.lbAddress);
            this.gbxPing.Controls.Add(this.tbxAddress);
            this.gbxPing.Location = new System.Drawing.Point(12, 327);
            this.gbxPing.Name = "gbxPing";
            this.gbxPing.Size = new System.Drawing.Size(332, 309);
            this.gbxPing.TabIndex = 3;
            this.gbxPing.TabStop = false;
            this.gbxPing.Text = "Проверка подключения";
            // 
            // btPing
            // 
            this.btPing.BackColor = System.Drawing.Color.LavenderBlush;
            this.btPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPing.Location = new System.Drawing.Point(82, 105);
            this.btPing.Name = "btPing";
            this.btPing.Size = new System.Drawing.Size(153, 40);
            this.btPing.TabIndex = 15;
            this.btPing.Text = "Проверить";
            this.btPing.UseVisualStyleBackColor = false;
            this.btPing.Click += new System.EventHandler(this.btPing_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(19, 157);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(117, 25);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "Результат:";
            // 
            // tbxResult
            // 
            this.tbxResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxResult.Location = new System.Drawing.Point(24, 186);
            this.tbxResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(287, 99);
            this.tbxResult.TabIndex = 13;
            this.tbxResult.Text = "";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(19, 31);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(75, 25);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Адрес:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxAddress.Location = new System.Drawing.Point(24, 61);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(287, 30);
            this.tbxAddress.TabIndex = 0;
            // 
            // gbxWifiInfo
            // 
            this.gbxWifiInfo.Controls.Add(this.pbxSignalQuality);
            this.gbxWifiInfo.Controls.Add(this.tbPassword);
            this.gbxWifiInfo.Controls.Add(this.lbPassword);
            this.gbxWifiInfo.Controls.Add(this.btConnected);
            this.gbxWifiInfo.Controls.Add(this.tbxIsSecure);
            this.gbxWifiInfo.Controls.Add(this.lbIsSecure);
            this.gbxWifiInfo.Controls.Add(this.tbxMacAddress);
            this.gbxWifiInfo.Controls.Add(this.tbxAuthType);
            this.gbxWifiInfo.Controls.Add(this.tbxSignalQuality);
            this.gbxWifiInfo.Controls.Add(this.tbxName);
            this.gbxWifiInfo.Controls.Add(this.lbMacAddress);
            this.gbxWifiInfo.Controls.Add(this.lbAuthType);
            this.gbxWifiInfo.Controls.Add(this.lbSignalQuality);
            this.gbxWifiInfo.Controls.Add(this.lbName);
            this.gbxWifiInfo.Location = new System.Drawing.Point(360, 327);
            this.gbxWifiInfo.Name = "gbxWifiInfo";
            this.gbxWifiInfo.Size = new System.Drawing.Size(480, 309);
            this.gbxWifiInfo.TabIndex = 4;
            this.gbxWifiInfo.TabStop = false;
            this.gbxWifiInfo.Text = "Информация о сети";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbPassword.Location = new System.Drawing.Point(247, 198);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 30);
            this.tbPassword.TabIndex = 18;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(242, 170);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(86, 25);
            this.lbPassword.TabIndex = 17;
            this.lbPassword.Text = "Пароль:";
            // 
            // btConnected
            // 
            this.btConnected.BackColor = System.Drawing.Color.LavenderBlush;
            this.btConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnected.Location = new System.Drawing.Point(147, 245);
            this.btConnected.Name = "btConnected";
            this.btConnected.Size = new System.Drawing.Size(185, 40);
            this.btConnected.TabIndex = 16;
            this.btConnected.Text = "Подключиться";
            this.btConnected.UseVisualStyleBackColor = false;
            this.btConnected.Click += new System.EventHandler(this.btConnected_Click);
            // 
            // tbxIsSecure
            // 
            this.tbxIsSecure.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxIsSecure.Location = new System.Drawing.Point(247, 132);
            this.tbxIsSecure.Name = "tbxIsSecure";
            this.tbxIsSecure.ReadOnly = true;
            this.tbxIsSecure.Size = new System.Drawing.Size(212, 30);
            this.tbxIsSecure.TabIndex = 9;
            // 
            // lbIsSecure
            // 
            this.lbIsSecure.AutoSize = true;
            this.lbIsSecure.Location = new System.Drawing.Point(242, 104);
            this.lbIsSecure.Name = "lbIsSecure";
            this.lbIsSecure.Size = new System.Drawing.Size(132, 25);
            this.lbIsSecure.TabIndex = 8;
            this.lbIsSecure.Text = "Тип защиты:";
            // 
            // tbxMacAddress
            // 
            this.tbxMacAddress.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxMacAddress.Location = new System.Drawing.Point(24, 198);
            this.tbxMacAddress.Name = "tbxMacAddress";
            this.tbxMacAddress.ReadOnly = true;
            this.tbxMacAddress.Size = new System.Drawing.Size(212, 30);
            this.tbxMacAddress.TabIndex = 7;
            // 
            // tbxAuthType
            // 
            this.tbxAuthType.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxAuthType.Location = new System.Drawing.Point(24, 132);
            this.tbxAuthType.Name = "tbxAuthType";
            this.tbxAuthType.ReadOnly = true;
            this.tbxAuthType.Size = new System.Drawing.Size(212, 30);
            this.tbxAuthType.TabIndex = 6;
            // 
            // tbxSignalQuality
            // 
            this.tbxSignalQuality.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxSignalQuality.Location = new System.Drawing.Point(247, 57);
            this.tbxSignalQuality.Name = "tbxSignalQuality";
            this.tbxSignalQuality.ReadOnly = true;
            this.tbxSignalQuality.Size = new System.Drawing.Size(212, 30);
            this.tbxSignalQuality.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbxName.Location = new System.Drawing.Point(24, 57);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(212, 30);
            this.tbxName.TabIndex = 4;
            // 
            // lbMacAddress
            // 
            this.lbMacAddress.AutoSize = true;
            this.lbMacAddress.Location = new System.Drawing.Point(19, 170);
            this.lbMacAddress.Name = "lbMacAddress";
            this.lbMacAddress.Size = new System.Drawing.Size(125, 25);
            this.lbMacAddress.TabIndex = 3;
            this.lbMacAddress.Text = "MAC-адрес:";
            // 
            // lbAuthType
            // 
            this.lbAuthType.AutoSize = true;
            this.lbAuthType.Location = new System.Drawing.Point(19, 104);
            this.lbAuthType.Name = "lbAuthType";
            this.lbAuthType.Size = new System.Drawing.Size(217, 25);
            this.lbAuthType.TabIndex = 2;
            this.lbAuthType.Text = "Тип аутентификации:";
            // 
            // lbSignalQuality
            // 
            this.lbSignalQuality.AutoSize = true;
            this.lbSignalQuality.Location = new System.Drawing.Point(242, 31);
            this.lbSignalQuality.Name = "lbSignalQuality";
            this.lbSignalQuality.Size = new System.Drawing.Size(182, 25);
            this.lbSignalQuality.TabIndex = 1;
            this.lbSignalQuality.Text = "Качество сигнала:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(105, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Название:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "0.ico");
            this.imageList.Images.SetKeyName(1, "1.ico");
            this.imageList.Images.SetKeyName(2, "2.ico");
            this.imageList.Images.SetKeyName(3, "3.ico");
            this.imageList.Images.SetKeyName(4, "4.ico");
            // 
            // pbxConnectedSignalQuality
            // 
            this.pbxConnectedSignalQuality.Location = new System.Drawing.Point(421, 19);
            this.pbxConnectedSignalQuality.Name = "pbxConnectedSignalQuality";
            this.pbxConnectedSignalQuality.Size = new System.Drawing.Size(38, 32);
            this.pbxConnectedSignalQuality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxConnectedSignalQuality.TabIndex = 17;
            this.pbxConnectedSignalQuality.TabStop = false;
            // 
            // pbxSignalQuality
            // 
            this.pbxSignalQuality.Location = new System.Drawing.Point(421, 19);
            this.pbxSignalQuality.Name = "pbxSignalQuality";
            this.pbxSignalQuality.Size = new System.Drawing.Size(38, 32);
            this.pbxSignalQuality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSignalQuality.TabIndex = 19;
            this.pbxSignalQuality.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(855, 648);
            this.Controls.Add(this.gbxWifiInfo);
            this.Controls.Add(this.gbxPing);
            this.Controls.Add(this.gbxWifiList);
            this.Controls.Add(this.gbxCurrentWifiInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Wifi-менеджер ";
            this.gbxCurrentWifiInfo.ResumeLayout(false);
            this.gbxCurrentWifiInfo.PerformLayout();
            this.gbxWifiList.ResumeLayout(false);
            this.gbxPing.ResumeLayout(false);
            this.gbxPing.PerformLayout();
            this.gbxWifiInfo.ResumeLayout(false);
            this.gbxWifiInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConnectedSignalQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSignalQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWifi;
        private System.Windows.Forms.GroupBox gbxCurrentWifiInfo;
        private System.Windows.Forms.Label lbConnectedSignalQuality;
        private System.Windows.Forms.Label lbConnectedName;
        private System.Windows.Forms.GroupBox gbxWifiList;
        private System.Windows.Forms.GroupBox gbxPing;
        private System.Windows.Forms.Label lbConnectedAuthType;
        private System.Windows.Forms.TextBox tbxConnectedMacAddress;
        private System.Windows.Forms.TextBox tbxConnectedAuthType;
        private System.Windows.Forms.TextBox tbxConnectedSignalQuality;
        private System.Windows.Forms.TextBox tbxConnectedName;
        private System.Windows.Forms.Label lbConnectedMacAddress;
        private System.Windows.Forms.Button btPing;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.RichTextBox tbxResult;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.TextBox tbxConnectedIsSecure;
        private System.Windows.Forms.Label lbConnectedIsSecure;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.GroupBox gbxWifiInfo;
        private System.Windows.Forms.Button btConnected;
        private System.Windows.Forms.TextBox tbxIsSecure;
        private System.Windows.Forms.Label lbIsSecure;
        private System.Windows.Forms.TextBox tbxMacAddress;
        private System.Windows.Forms.TextBox tbxAuthType;
        private System.Windows.Forms.TextBox tbxSignalQuality;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbMacAddress;
        private System.Windows.Forms.Label lbAuthType;
        private System.Windows.Forms.Label lbSignalQuality;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pbxConnectedSignalQuality;
        private System.Windows.Forms.PictureBox pbxSignalQuality;
    }
}

