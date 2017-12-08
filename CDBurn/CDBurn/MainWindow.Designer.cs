using ExtendedDotNET.Controls.Progress;

namespace CDBurn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tcFunction = new System.Windows.Forms.TabControl();
            this.tpBurn = new System.Windows.Forms.TabPage();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btBurn = new System.Windows.Forms.Button();
            this.btRemoveFile = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.UsedSpaceBar = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.gbDisc = new System.Windows.Forms.GroupBox();
            this.btUpdateDiscRecorders = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.cbDiscRecorders = new System.Windows.Forms.ComboBox();
            this.tpFormat = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cbDisc = new System.Windows.Forms.ComboBox();
            this.btFormat = new System.Windows.Forms.Button();
            this.tbSizeF = new System.Windows.Forms.TextBox();
            this.lbSizeF = new System.Windows.Forms.Label();
            this.tbTypeF = new System.Windows.Forms.TextBox();
            this.lbTypeF = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tcFunction.SuspendLayout();
            this.tpBurn.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.gbDisc.SuspendLayout();
            this.tpFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFunction
            // 
            this.tcFunction.Controls.Add(this.tpBurn);
            this.tcFunction.Controls.Add(this.tpFormat);
            this.tcFunction.Font = new System.Drawing.Font("PG Isadora Cyr Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcFunction.Location = new System.Drawing.Point(14, 12);
            this.tcFunction.Name = "tcFunction";
            this.tcFunction.SelectedIndex = 0;
            this.tcFunction.Size = new System.Drawing.Size(793, 430);
            this.tcFunction.TabIndex = 0;
            this.tcFunction.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcFunction_Selecting);
            // 
            // tpBurn
            // 
            this.tpBurn.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpBurn.Controls.Add(this.gbFiles);
            this.tpBurn.Controls.Add(this.gbDisc);
            this.tpBurn.Location = new System.Drawing.Point(4, 35);
            this.tpBurn.Name = "tpBurn";
            this.tpBurn.Padding = new System.Windows.Forms.Padding(3);
            this.tpBurn.Size = new System.Drawing.Size(785, 391);
            this.tpBurn.TabIndex = 0;
            this.tpBurn.Text = "Записать";
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btBurn);
            this.gbFiles.Controls.Add(this.btRemoveFile);
            this.gbFiles.Controls.Add(this.btAddFile);
            this.gbFiles.Controls.Add(this.UsedSpaceBar);
            this.gbFiles.Controls.Add(this.lbFiles);
            this.gbFiles.Location = new System.Drawing.Point(281, 7);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(498, 378);
            this.gbFiles.TabIndex = 1;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Файлы";
            // 
            // btBurn
            // 
            this.btBurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBurn.Location = new System.Drawing.Point(125, 329);
            this.btBurn.Name = "btBurn";
            this.btBurn.Size = new System.Drawing.Size(232, 37);
            this.btBurn.TabIndex = 4;
            this.btBurn.Text = "Записать";
            this.btBurn.UseVisualStyleBackColor = true;
            this.btBurn.Click += new System.EventHandler(this.btBurn_Click);
            // 
            // btRemoveFile
            // 
            this.btRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveFile.Location = new System.Drawing.Point(260, 286);
            this.btRemoveFile.Name = "btRemoveFile";
            this.btRemoveFile.Size = new System.Drawing.Size(232, 37);
            this.btRemoveFile.TabIndex = 3;
            this.btRemoveFile.Text = "Удалить файл";
            this.btRemoveFile.UseVisualStyleBackColor = true;
            this.btRemoveFile.Click += new System.EventHandler(this.btRemoveFile_Click);
            // 
            // btAddFile
            // 
            this.btAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddFile.Location = new System.Drawing.Point(7, 286);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(232, 37);
            this.btAddFile.TabIndex = 2;
            this.btAddFile.Text = "Добавить файл";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // UsedSpaceBar
            // 
            this.UsedSpaceBar.BarOffset = 1;
            this.UsedSpaceBar.Caption = "";
            this.UsedSpaceBar.CaptionColor = System.Drawing.Color.Black;
            this.UsedSpaceBar.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.UsedSpaceBar.CaptionShadowColor = System.Drawing.Color.White;
            this.UsedSpaceBar.ChangeByMouse = false;
            this.UsedSpaceBar.DashSpace = 2;
            this.UsedSpaceBar.DashWidth = 5;
            this.UsedSpaceBar.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.UsedSpaceBar.EdgeColor = System.Drawing.Color.Gray;
            this.UsedSpaceBar.EdgeLightColor = System.Drawing.Color.LightGray;
            this.UsedSpaceBar.EdgeWidth = 1;
            this.UsedSpaceBar.FloodPercentage = 0.2F;
            this.UsedSpaceBar.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.UsedSpaceBar.Invert = false;
            this.UsedSpaceBar.Location = new System.Drawing.Point(6, 251);
            this.UsedSpaceBar.MainColor = System.Drawing.Color.Purple;
            this.UsedSpaceBar.Maximum = 100;
            this.UsedSpaceBar.Minimum = 0;
            this.UsedSpaceBar.Name = "UsedSpaceBar";
            this.UsedSpaceBar.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.UsedSpaceBar.ProgressBackColor = System.Drawing.Color.LavenderBlush;
            this.UsedSpaceBar.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.UsedSpaceBar.SecondColor = System.Drawing.Color.White;
            this.UsedSpaceBar.Shadow = true;
            this.UsedSpaceBar.ShadowOffset = 1;
            this.UsedSpaceBar.Size = new System.Drawing.Size(485, 23);
            this.UsedSpaceBar.Step = 1;
            this.UsedSpaceBar.TabIndex = 1;
            this.UsedSpaceBar.TextAntialias = true;
            this.UsedSpaceBar.Value = 0;
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 26;
            this.lbFiles.Location = new System.Drawing.Point(7, 33);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(485, 212);
            this.lbFiles.TabIndex = 0;
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // gbDisc
            // 
            this.gbDisc.Controls.Add(this.btUpdateDiscRecorders);
            this.gbDisc.Controls.Add(this.tbSize);
            this.gbDisc.Controls.Add(this.lbSize);
            this.gbDisc.Controls.Add(this.tbType);
            this.gbDisc.Controls.Add(this.lbType);
            this.gbDisc.Controls.Add(this.cbDiscRecorders);
            this.gbDisc.Location = new System.Drawing.Point(7, 7);
            this.gbDisc.Name = "gbDisc";
            this.gbDisc.Size = new System.Drawing.Size(267, 378);
            this.gbDisc.TabIndex = 0;
            this.gbDisc.TabStop = false;
            this.gbDisc.Text = "Диск";
            // 
            // btUpdateDiscRecorders
            // 
            this.btUpdateDiscRecorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateDiscRecorders.Location = new System.Drawing.Point(35, 256);
            this.btUpdateDiscRecorders.Name = "btUpdateDiscRecorders";
            this.btUpdateDiscRecorders.Size = new System.Drawing.Size(181, 88);
            this.btUpdateDiscRecorders.TabIndex = 5;
            this.btUpdateDiscRecorders.Text = "Обновить список дисков";
            this.btUpdateDiscRecorders.UseVisualStyleBackColor = true;
            this.btUpdateDiscRecorders.Click += new System.EventHandler(this.btUpdateDiscRecorders_Click);
            // 
            // tbSize
            // 
            this.tbSize.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbSize.Location = new System.Drawing.Point(115, 167);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(145, 33);
            this.tbSize.TabIndex = 4;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(6, 170);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(103, 27);
            this.lbSize.TabIndex = 3;
            this.lbSize.Text = "Размер:";
            // 
            // tbType
            // 
            this.tbType.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbType.Location = new System.Drawing.Point(76, 120);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(185, 33);
            this.tbType.TabIndex = 2;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(7, 123);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(63, 27);
            this.lbType.TabIndex = 1;
            this.lbType.Text = "Тип:";
            // 
            // cbDiscRecorders
            // 
            this.cbDiscRecorders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscRecorders.FormattingEnabled = true;
            this.cbDiscRecorders.Location = new System.Drawing.Point(7, 52);
            this.cbDiscRecorders.Name = "cbDiscRecorders";
            this.cbDiscRecorders.Size = new System.Drawing.Size(254, 34);
            this.cbDiscRecorders.TabIndex = 0;
            this.cbDiscRecorders.SelectedIndexChanged += new System.EventHandler(this.cbDiscRecorders_SelectedIndexChanged);
            // 
            // tpFormat
            // 
            this.tpFormat.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpFormat.Controls.Add(this.tbSizeF);
            this.tpFormat.Controls.Add(this.lbSizeF);
            this.tpFormat.Controls.Add(this.tbTypeF);
            this.tpFormat.Controls.Add(this.lbTypeF);
            this.tpFormat.Controls.Add(this.btFormat);
            this.tpFormat.Controls.Add(this.cbDisc);
            this.tpFormat.Location = new System.Drawing.Point(4, 35);
            this.tpFormat.Name = "tpFormat";
            this.tpFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormat.Size = new System.Drawing.Size(785, 391);
            this.tpFormat.TabIndex = 1;
            this.tpFormat.Text = "Очистить";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // cbDisc
            // 
            this.cbDisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisc.FormattingEnabled = true;
            this.cbDisc.Location = new System.Drawing.Point(260, 50);
            this.cbDisc.Name = "cbDisc";
            this.cbDisc.Size = new System.Drawing.Size(250, 34);
            this.cbDisc.TabIndex = 0;
            this.cbDisc.SelectedIndexChanged += new System.EventHandler(this.cbDisc_SelectedIndexChanged);
            // 
            // btFormat
            // 
            this.btFormat.Enabled = false;
            this.btFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFormat.Location = new System.Drawing.Point(260, 230);
            this.btFormat.Name = "btFormat";
            this.btFormat.Size = new System.Drawing.Size(250, 44);
            this.btFormat.TabIndex = 1;
            this.btFormat.Text = "Очистить";
            this.btFormat.UseVisualStyleBackColor = true;
            this.btFormat.Click += new System.EventHandler(this.btFormat_Click);
            // 
            // tbSizeF
            // 
            this.tbSizeF.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbSizeF.Location = new System.Drawing.Point(364, 162);
            this.tbSizeF.Name = "tbSizeF";
            this.tbSizeF.ReadOnly = true;
            this.tbSizeF.Size = new System.Drawing.Size(146, 33);
            this.tbSizeF.TabIndex = 8;
            // 
            // lbSizeF
            // 
            this.lbSizeF.AutoSize = true;
            this.lbSizeF.Location = new System.Drawing.Point(255, 165);
            this.lbSizeF.Name = "lbSizeF";
            this.lbSizeF.Size = new System.Drawing.Size(103, 27);
            this.lbSizeF.TabIndex = 7;
            this.lbSizeF.Text = "Размер:";
            // 
            // tbTypeF
            // 
            this.tbTypeF.BackColor = System.Drawing.Color.LavenderBlush;
            this.tbTypeF.Location = new System.Drawing.Point(325, 115);
            this.tbTypeF.Name = "tbTypeF";
            this.tbTypeF.ReadOnly = true;
            this.tbTypeF.Size = new System.Drawing.Size(185, 33);
            this.tbTypeF.TabIndex = 6;
            // 
            // lbTypeF
            // 
            this.lbTypeF.AutoSize = true;
            this.lbTypeF.Location = new System.Drawing.Point(256, 118);
            this.lbTypeF.Name = "lbTypeF";
            this.lbTypeF.Size = new System.Drawing.Size(63, 27);
            this.lbTypeF.TabIndex = 5;
            this.lbTypeF.Text = "Тип:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CD Burn";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(820, 453);
            this.Controls.Add(this.tcFunction);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "CD Burn";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tcFunction.ResumeLayout(false);
            this.tpBurn.ResumeLayout(false);
            this.gbFiles.ResumeLayout(false);
            this.gbDisc.ResumeLayout(false);
            this.gbDisc.PerformLayout();
            this.tpFormat.ResumeLayout(false);
            this.tpFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFunction;
        private System.Windows.Forms.TabPage tpBurn;
        private System.Windows.Forms.TabPage tpFormat;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.GroupBox gbDisc;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbDiscRecorders;
        private System.Windows.Forms.Button btBurn;
        private System.Windows.Forms.Button btRemoveFile;
        private System.Windows.Forms.Button btAddFile;
        private ProgressBar UsedSpaceBar;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btUpdateDiscRecorders;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbSizeF;
        private System.Windows.Forms.Label lbSizeF;
        private System.Windows.Forms.TextBox tbTypeF;
        private System.Windows.Forms.Label lbTypeF;
        private System.Windows.Forms.Button btFormat;
        private System.Windows.Forms.ComboBox cbDisc;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

