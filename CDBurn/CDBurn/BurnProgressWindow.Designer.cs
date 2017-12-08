namespace CDBurn
{
    partial class BurnProgressWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurnProgressWindow));
            this.ProgressBar = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.btOK = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.BarOffset = 1;
            this.ProgressBar.Caption = "";
            this.ProgressBar.CaptionColor = System.Drawing.Color.Black;
            this.ProgressBar.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.Custom;
            this.ProgressBar.CaptionShadowColor = System.Drawing.Color.White;
            this.ProgressBar.ChangeByMouse = false;
            this.ProgressBar.DashSpace = 2;
            this.ProgressBar.DashWidth = 5;
            this.ProgressBar.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.Rounded;
            this.ProgressBar.EdgeColor = System.Drawing.Color.Gray;
            this.ProgressBar.EdgeLightColor = System.Drawing.Color.LightGray;
            this.ProgressBar.EdgeWidth = 1;
            this.ProgressBar.FloodPercentage = 0.2F;
            this.ProgressBar.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.ProgressBar.Invert = false;
            this.ProgressBar.Location = new System.Drawing.Point(12, 40);
            this.ProgressBar.MainColor = System.Drawing.Color.Purple;
            this.ProgressBar.Maximum = 100;
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Horizontal;
            this.ProgressBar.ProgressBackColor = System.Drawing.Color.LavenderBlush;
            this.ProgressBar.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Dashed;
            this.ProgressBar.SecondColor = System.Drawing.Color.White;
            this.ProgressBar.Shadow = true;
            this.ProgressBar.ShadowOffset = 1;
            this.ProgressBar.Size = new System.Drawing.Size(730, 69);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 2;
            this.ProgressBar.TextAntialias = true;
            this.ProgressBar.Value = 0;
            // 
            // btOK
            // 
            this.btOK.Enabled = false;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.Location = new System.Drawing.Point(284, 139);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(171, 40);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "CDBurn";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // BurnProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(754, 191);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.ProgressBar);
            this.Font = new System.Drawing.Font("PG Isadora Cyr Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BurnProgressWindow";
            this.Text = "CD Burn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BurnProgressWindow_FormClosing);
            this.Resize += new System.EventHandler(this.BurnProgressWindow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedDotNET.Controls.Progress.ProgressBar ProgressBar;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}