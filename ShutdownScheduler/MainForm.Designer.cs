namespace ShutdownScheduler
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnShutdownOrCancel = new System.Windows.Forms.Button();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimeType = new System.Windows.Forms.ComboBox();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.cbCustomMessagebox = new System.Windows.Forms.CheckBox();
            this.pbHelpIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShutdownOrCancel
            // 
            this.btnShutdownOrCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownOrCancel.Location = new System.Drawing.Point(12, 199);
            this.btnShutdownOrCancel.Name = "btnShutdownOrCancel";
            this.btnShutdownOrCancel.Size = new System.Drawing.Size(367, 34);
            this.btnShutdownOrCancel.TabIndex = 0;
            this.btnShutdownOrCancel.Text = "Schedule shutdown";
            this.btnShutdownOrCancel.UseVisualStyleBackColor = true;
            this.btnShutdownOrCancel.Click += new System.EventHandler(this.btnShutdownOrCancel_Click);
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(9, 31);
            this.numTime.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(106, 22);
            this.numTime.TabIndex = 1;
            this.numTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTimeType);
            this.groupBox1.Controls.Add(this.rbLogOff);
            this.groupBox1.Controls.Add(this.rbRestart);
            this.groupBox1.Controls.Add(this.rbShutdown);
            this.groupBox1.Controls.Add(this.numTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shutdown options";
            // 
            // cbTimeType
            // 
            this.cbTimeType.FormattingEnabled = true;
            this.cbTimeType.Location = new System.Drawing.Point(121, 31);
            this.cbTimeType.Name = "cbTimeType";
            this.cbTimeType.Size = new System.Drawing.Size(121, 24);
            this.cbTimeType.TabIndex = 8;
            this.cbTimeType.SelectedIndexChanged += new System.EventHandler(this.cbTimeType_SelectedIndexChanged);
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(9, 94);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(76, 21);
            this.rbLogOff.TabIndex = 7;
            this.rbLogOff.Text = "Log Off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(9, 121);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(75, 21);
            this.rbRestart.TabIndex = 6;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Checked = true;
            this.rbShutdown.Location = new System.Drawing.Point(9, 67);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(91, 21);
            this.rbShutdown.TabIndex = 5;
            this.rbShutdown.TabStop = true;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // cbCustomMessagebox
            // 
            this.cbCustomMessagebox.AutoSize = true;
            this.cbCustomMessagebox.Checked = true;
            this.cbCustomMessagebox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCustomMessagebox.Location = new System.Drawing.Point(21, 172);
            this.cbCustomMessagebox.Name = "cbCustomMessagebox";
            this.cbCustomMessagebox.Size = new System.Drawing.Size(196, 21);
            this.cbCustomMessagebox.TabIndex = 6;
            this.cbCustomMessagebox.Text = "Show custom messagebox";
            this.cbCustomMessagebox.UseVisualStyleBackColor = true;
            this.cbCustomMessagebox.CheckedChanged += new System.EventHandler(this.cbCustomMessagebox_CheckedChanged);
            // 
            // pbHelpIcon
            // 
            this.pbHelpIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbHelpIcon.Image")));
            this.pbHelpIcon.Location = new System.Drawing.Point(214, 168);
            this.pbHelpIcon.Name = "pbHelpIcon";
            this.pbHelpIcon.Size = new System.Drawing.Size(19, 29);
            this.pbHelpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelpIcon.TabIndex = 7;
            this.pbHelpIcon.TabStop = false;
            this.pbHelpIcon.Click += new System.EventHandler(this.pbHelpIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 245);
            this.Controls.Add(this.pbHelpIcon);
            this.Controls.Add(this.cbCustomMessagebox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShutdownOrCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShutdownOrCancel;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.ComboBox cbTimeType;
        private System.Windows.Forms.CheckBox cbCustomMessagebox;
        private System.Windows.Forms.PictureBox pbHelpIcon;
    }
}

