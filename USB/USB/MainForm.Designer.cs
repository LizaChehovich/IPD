namespace USB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dGVDevices = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSpaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeSpaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usedSpaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEject = new System.Windows.Forms.Button();
            this.extraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDevices
            // 
            this.dGVDevices.AllowUserToAddRows = false;
            this.dGVDevices.AllowUserToDeleteRows = false;
            this.dGVDevices.BackgroundColor = System.Drawing.Color.Pink;
            this.dGVDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.totalSpaceColumn,
            this.freeSpaceColumn,
            this.usedSpaceColumn,
            this.extraColumn});
            this.dGVDevices.Location = new System.Drawing.Point(13, 13);
            this.dGVDevices.MultiSelect = false;
            this.dGVDevices.Name = "dGVDevices";
            this.dGVDevices.ReadOnly = true;
            this.dGVDevices.RowTemplate.Height = 24;
            this.dGVDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDevices.Size = new System.Drawing.Size(925, 450);
            this.dGVDevices.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Устройство";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Тип";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // totalSpaceColumn
            // 
            this.totalSpaceColumn.HeaderText = "Ёмкость";
            this.totalSpaceColumn.Name = "totalSpaceColumn";
            this.totalSpaceColumn.ReadOnly = true;
            // 
            // freeSpaceColumn
            // 
            this.freeSpaceColumn.HeaderText = "Свободно";
            this.freeSpaceColumn.Name = "freeSpaceColumn";
            this.freeSpaceColumn.ReadOnly = true;
            // 
            // usedSpaceColumn
            // 
            this.usedSpaceColumn.HeaderText = "Занято";
            this.usedSpaceColumn.Name = "usedSpaceColumn";
            this.usedSpaceColumn.ReadOnly = true;
            // 
            // btEject
            // 
            this.btEject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEject.ForeColor = System.Drawing.Color.Black;
            this.btEject.Location = new System.Drawing.Point(404, 479);
            this.btEject.Name = "btEject";
            this.btEject.Size = new System.Drawing.Size(149, 32);
            this.btEject.TabIndex = 1;
            this.btEject.Text = "Извлечь";
            this.btEject.UseVisualStyleBackColor = true;
            this.btEject.Click += new System.EventHandler(this.btEject_Click);
            // 
            // extraColumn
            // 
            this.extraColumn.HeaderText = "Дополнительно";
            this.extraColumn.Name = "extraColumn";
            this.extraColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(950, 523);
            this.Controls.Add(this.btEject);
            this.Controls.Add(this.dGVDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "USB Devices";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDevices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSpaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeSpaceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usedSpaceColumn;
        private System.Windows.Forms.Button btEject;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraColumn;
    }
}

