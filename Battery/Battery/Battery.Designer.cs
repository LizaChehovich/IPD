namespace Battery
{
    partial class Battery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battery));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTimeChange = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbPercentageChange = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbStateChange = new System.Windows.Forms.Label();
            this.gbTimeOut = new System.Windows.Forms.GroupBox();
            this.cbTimeOut = new System.Windows.Forms.ComboBox();
            this.lbTimeOut = new System.Windows.Forms.Label();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.gbTimeOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbTimeChange, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbPercentageChange, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPercentage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbState, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStateChange, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbTimeChange
            // 
            this.lbTimeChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeChange.AutoSize = true;
            this.lbTimeChange.Enabled = false;
            this.lbTimeChange.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeChange.Location = new System.Drawing.Point(212, 204);
            this.lbTimeChange.Name = "lbTimeChange";
            this.lbTimeChange.Size = new System.Drawing.Size(203, 104);
            this.lbTimeChange.TabIndex = 5;
            this.lbTimeChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Enabled = false;
            this.lbTime.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(3, 204);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(203, 104);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Оставшееся время работы:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPercentageChange
            // 
            this.lbPercentageChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentageChange.AutoSize = true;
            this.lbPercentageChange.Enabled = false;
            this.lbPercentageChange.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPercentageChange.Location = new System.Drawing.Point(212, 102);
            this.lbPercentageChange.Name = "lbPercentageChange";
            this.lbPercentageChange.Size = new System.Drawing.Size(203, 102);
            this.lbPercentageChange.TabIndex = 3;
            this.lbPercentageChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPercentage
            // 
            this.lbPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Enabled = false;
            this.lbPercentage.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPercentage.Location = new System.Drawing.Point(3, 102);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(203, 102);
            this.lbPercentage.TabIndex = 2;
            this.lbPercentage.Text = "Заряд батареи:";
            this.lbPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbState
            // 
            this.lbState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbState.AutoSize = true;
            this.lbState.Enabled = false;
            this.lbState.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbState.Location = new System.Drawing.Point(3, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(203, 102);
            this.lbState.TabIndex = 0;
            this.lbState.Text = "Состояние батареи:";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStateChange
            // 
            this.lbStateChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStateChange.AutoSize = true;
            this.lbStateChange.Enabled = false;
            this.lbStateChange.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStateChange.Location = new System.Drawing.Point(212, 0);
            this.lbStateChange.Name = "lbStateChange";
            this.lbStateChange.Size = new System.Drawing.Size(203, 102);
            this.lbStateChange.TabIndex = 1;
            this.lbStateChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTimeOut
            // 
            this.gbTimeOut.Controls.Add(this.cbTimeOut);
            this.gbTimeOut.Controls.Add(this.lbTimeOut);
            this.gbTimeOut.Location = new System.Drawing.Point(427, 2);
            this.gbTimeOut.Name = "gbTimeOut";
            this.gbTimeOut.Size = new System.Drawing.Size(168, 299);
            this.gbTimeOut.TabIndex = 1;
            this.gbTimeOut.TabStop = false;
            // 
            // cbTimeOut
            // 
            this.cbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeOut.FormattingEnabled = true;
            this.cbTimeOut.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "10",
            "15",
            "20"});
            this.cbTimeOut.Location = new System.Drawing.Point(7, 49);
            this.cbTimeOut.Name = "cbTimeOut";
            this.cbTimeOut.Size = new System.Drawing.Size(153, 24);
            this.cbTimeOut.TabIndex = 1;
            this.cbTimeOut.SelectedIndexChanged += new System.EventHandler(this.cbTimeOut_SelectedIndexChanged);
            // 
            // lbTimeOut
            // 
            this.lbTimeOut.AutoSize = true;
            this.lbTimeOut.Enabled = false;
            this.lbTimeOut.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeOut.Location = new System.Drawing.Point(7, 11);
            this.lbTimeOut.Name = "lbTimeOut";
            this.lbTimeOut.Size = new System.Drawing.Size(153, 34);
            this.lbTimeOut.TabIndex = 0;
            this.lbTimeOut.Text = "Время (мин):";
            // 
            // Battery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(599, 313);
            this.Controls.Add(this.gbTimeOut);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Battery";
            this.Text = "Менеджер электропитания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battery_FormClosing);
            this.Load += new System.EventHandler(this.Battery_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbTimeOut.ResumeLayout(false);
            this.gbTimeOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbTimeOut;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbTimeChange;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbPercentageChange;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label lbStateChange;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.ComboBox cbTimeOut;
        private System.Windows.Forms.Timer tmUpdate;
    }
}

